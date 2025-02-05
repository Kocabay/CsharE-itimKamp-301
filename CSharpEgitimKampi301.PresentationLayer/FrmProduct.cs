using CsharEğitimKampı301.BussinessLayer.Abstract;
using CsharEğitimKampı301.BussinessLayer.Concrete;
using CsharEğitimKampı301.DataAccessLayer.EntityFramework;
using CsharEğitimKampı301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var vales = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = vales;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var values = _productService.TGetById(id);
            _productService.TDelete(values);
            MessageBox.Show("Ürün Silindi");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = Convert.ToInt32(cmbKategori.SelectedValue.ToString());
            product.ProductName = txtProductName.Text;
            product.ProductPrice = decimal.Parse(txtPrice.Text);
            product.ProductDescription = txtAcıkalma.Text;
            product.ProductStock = Convert.ToInt32(txtStock.Text);
            _productService.TInsert(product);
            MessageBox.Show($"{product.ProductId}'li Ürün Eklendi");
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var values = _productService.TGetById(id);
            dataGridView1.DataSource = values;
            MessageBox.Show($"{id}'li Ürün Getirildi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var values = _productService.TGetById(id);
            values.ProductDescription = txtAcıkalma.Text;
            values.ProductName = txtProductName.Text;
            values.ProductPrice = decimal.Parse(txtPrice.Text);
            values.ProductStock = Convert.ToInt32(txtStock.Text);
            values.CategoryId = Convert.ToInt32(cmbKategori.SelectedValue.ToString());

            _productService.TUpdate(values);
            MessageBox.Show($"{id}'li Ürün Güncellendi");
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbKategori.DataSource = values;
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryId";
        }
    }
}
