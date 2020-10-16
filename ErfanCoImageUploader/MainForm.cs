using DNTPersianUtils.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ErfanCoImageUploader
{
    public partial class MainForm : Form
    {
        private Repository _repository;
        public List<Product> _Products;
        public MainForm()
        {
            try
            {
                InitializeComponent();
                _repository = new Repository();
                _Products = new List<Product>();
                this.Icon = Properties.Resources.Hadezign_Hobbies_Photography;
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Extension.IsSqlServerAvailable())
                {
                    MessageBox.Show("اتصال به سرور برقرار نیست");
                    Application.Exit();
                    return;
                }
                _repository.RunStartupScript();
                BindGrid();

            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }
        private void BindGrid()
        {
            try
            {
                _Products = _repository.GetAllProducts();
                _Products.ForEach(l => l.K_Name = l.K_Name.ApplyCorrectYeKe());
                _Products.ForEach(l => l.KArtNo = l.KArtNo.ApplyCorrectYeKe());
                _Products.ForEach(l => l.KBarCode = l.KBarCode.ApplyCorrectYeKe());
                dgvMain.AutoGenerateColumns = false;
                dgvMain.DataSource = _Products;
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                {
                    dgvMain.AutoGenerateColumns = false;
                    dgvMain.DataSource = _Products;
                }
                var searchkey = tbxSearch.Text;
                searchkey = searchkey.ToEnglishNumbers();
                searchkey = searchkey.ApplyCorrectYeKe();
                dgvMain.AutoGenerateColumns = false;
                dgvMain.DataSource = _Products.Where(l => l.KArtNo.ToLower().Contains(searchkey.ToLower()) || l.KBarCode.ToLower().Contains(searchkey.ToLower()) || l.K_Name.ToLower().Contains(searchkey.ToLower())).ToList();
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMain.CurrentRow == null) { MessageBox.Show("ردیف کالا را انتخاب نمایید"); return; };
                OpenFileDialog open = new OpenFileDialog
                {
                    Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;"
                };
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (ValidFile(open.FileName, 153600))
                    {
                        ImgCurrentKala.Image = new Bitmap(open.FileName);
                        _repository.SetProductPicture(dgvMain.CurrentRow.Cells["ERPCode"].Value.ToString(), Extension.ImageToByteArray(ImgCurrentKala.Image));
                    }
                    else
                    {
                        MessageBox.Show("سایز تصویر نبایستی بزرگتر از 150 کیلوبایت باشد");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }
        private bool ValidFile(string filename, long limitInBytes)
        {
            var fileSizeInBytes = new FileInfo(filename).Length;
            if (fileSizeInBytes > limitInBytes) return false;
            return true;
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMain.CurrentRow == null) { MessageBox.Show("ردیف کالا را انتخاب نمایید"); return; };
                _repository.ClearProductImage(dgvMain.CurrentRow.Cells["ERPCode"].Value.ToString());
                ImgCurrentKala.Image = Properties.Resources.Unknown;
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMain.CurrentRow == null) return;
                tbxCurrentKalaName.Text = dgvMain.CurrentRow.Cells["K_Name"].Value.ToString();
                tbxCurrentKalaBarcode.Text = dgvMain.CurrentRow.Cells["KBarcode"].Value.ToString();
                tbxCurrentKalaSalePrice.Text = decimal.Parse(dgvMain.CurrentRow.Cells["K_price_sail"].Value.ToString()).ToString("N0");
                var picdata = _repository.GetProductPic(dgvMain.CurrentRow.Cells["ERPCode"].Value.ToString());
                if (picdata == null || picdata.Picture == null)
                {
                    ImgCurrentKala.Image = Properties.Resources.Unknown;
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(picdata.Picture))
                    {
                        ImgCurrentKala.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}