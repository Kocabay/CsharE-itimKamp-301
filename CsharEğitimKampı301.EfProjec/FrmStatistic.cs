using System;
using System.Linq;
using System.Windows.Forms;

namespace CsharEğitimKampı301.EfProjec
{
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistic_Load(object sender, EventArgs e)
        {

            lblLocationCount.Text = db.Location.Count().ToString();  //Toplam Lokasyon Sayısı
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString(); //Toplam Kapasite
            lblGuideCount.Text = db.Guide.Count().ToString(); //Toplam Rehber Sayısı
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString(); //Ortalama Kapasite
            lblAvgLocatinoPrice.Text = db.Location.Average(x => x.Price)?.ToString("0.00") + "$"; //Ortalama Lokasyon Fiyatı
            int lastCountry = db.Location.Max(x => x.LocationId);
            lblLastCountry.Text = db.Location.Where(x => x.LocationId == lastCountry).Select(x => x.Country).FirstOrDefault(); //Son Eklenen Ülke
            lblCappadoLocation.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString(); //Nevşehir'deki Lokasyon Sayısı
            lblTurkiyeAvgCapacity.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString(); //Türkiye'deki Ortalama Kapasite
            var romeguideıd = db.Location.Where(x=>x.City =="Roma Turistik").Select(y =>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeguideıd).Select(y => y.GuideName + " " + y.GuidSurname).FirstOrDefault(); //Roma'daki Rehberin Adı Soyadı

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacity.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault(); //En Fazla Kapasiteli Lokasyon

            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxTour.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault(); //En Pahalı Lokasyon

            var guideıdbynameAyseCınar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuidSurname == "Cınar").Select(y => y.GuideId).FirstOrDefault();
            lblAyseGulCınar.Text = db.Location.Where(x=>x.GuideId == guideıdbynameAyseCınar).Count().ToString(); //Ayşe Gül Çınar'ın Rehberliğindeki Lokasyon Sayısı
        }
    }
}
