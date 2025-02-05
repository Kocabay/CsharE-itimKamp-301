using CsharE�itimKamp�301.BussinessLayer.Abstract;
using CsharE�itimKamp�301.BussinessLayer.Concrete;
using CsharE�itimKamp�301.DataAccessLayer.EntityFramework;
using CsharE�itimKamp�301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtKategoriAd.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Kategori Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriId.Text);
            var deletedvalues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedvalues);
            MessageBox.Show("Kategori Silindi");
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriId.Text);
            var values = _categoryService.TGetById(id);
            dataGridView1.DataSource = values;

        }

        private void btnG�ncelle_Click(object sender, EventArgs e)
        {
     
            int update�d =int.Parse(txtKategoriId.Text);
            var updatevalue = _categoryService.TGetById(update�d);
            updatevalue.CategoryName = txtKategoriAd.Text;
            updatevalue.CategoryStatus = true;
            _categoryService.TUpdate(updatevalue);

        }
    }
}
