using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharEğitimKampı301.EfProjec
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuidSurname,
                x.GuideId
            }).ToList();
            cmbGuide11.DisplayMember = "FullName";
            cmbGuide11.ValueMember = "GuideId";
            cmbGuide11.DataSource = values;
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtsehir.Text;
            location.Country = txtulke.Text;
            location.DayNight = txtdaynigh.Text;
            location.Price = decimal.Parse(txtpricee.Text);
            location.GuideId = int.Parse(cmbGuide11.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Location.Find(id);
            db.Location.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Location.Find(id);
            updateValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updateValue.City = txtsehir.Text;
            updateValue.Country = txtulke.Text;
            updateValue.DayNight = txtdaynigh.Text;
            updateValue.Price = decimal.Parse(txtpricee.Text);
            updateValue.GuideId = int.Parse(cmbGuide11.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Lokasyon Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
