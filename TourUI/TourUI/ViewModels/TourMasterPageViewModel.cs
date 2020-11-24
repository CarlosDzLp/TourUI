using System;
using System.Collections.ObjectModel;
using TourUI.Models;

namespace TourUI.ViewModels
{
    public class TourMasterPageViewModel
    {
        #region Properties
        public ObservableCollection<CityModel> ListCity { get; set; }
        #endregion

        #region Constructor
        public TourMasterPageViewModel()
        {
            LoadCity();
        }
        #endregion

        #region Methods
        private void LoadCity()
        {
            try
            {
                ListCity = new ObservableCollection<CityModel>();
                ListCity.Add(new CityModel
                {
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting",
                    Location = "Nueva Delhi",
                    Name = "India",
                    Price = 340.00,
                    Rating = 4.5,
                    Restaurant = false,
                    Type = "New",
                    Umbrella = true,
                    Wifi = true,
                    Worked = true,
                    PathImage = "https://a.travel-assets.com/findyours-php/viewfinder/images/res40/101000/101661-Idukki-District.jpg"
                });
                ListCity.Add(new CityModel
                {
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting",
                    Location = "Krabi",
                    Name = "Thailand",
                    Price = 540.00,
                    Rating = 2.5,
                    Restaurant = true,
                    Type = "Sale",
                    Umbrella = true,
                    Wifi = true,
                    Worked = true,
                    PathImage = "https://i.pinimg.com/originals/df/3c/f0/df3cf015a80d69dc53e39d90e3a932f2.jpg"
                });
                ListCity.Add(new CityModel
                {
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting",
                    Location = "Huasteca Potosina en San Luis Potosí",
                    Name = "San Luis Potosi",
                    Price = 140.00,
                    Rating = 4.0,
                    Restaurant = false,
                    Type = "Sale",
                    Umbrella = true,
                    Wifi = false,
                    Worked = true,
                    PathImage = "https://rsrbs-development.s3.amazonaws.com/uploads/cascadas_de_tamul_mexico_naturaleza.jpg"
                });
                ListCity.Add(new CityModel
                {
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting",
                    Location = "Asheville",
                    Name = "USA",
                    Price = 540.00,
                    Rating = 3.5,
                    Restaurant = false,
                    Type = "New",
                    Umbrella = false,
                    Wifi = false,
                    Worked = true,
                    PathImage = "https://www.choicehotels.com/cms/images/choice-hotels/explore/hero-explore-asheville-attractions-city/hero-explore-asheville-attractions-city.jpg"
                });
                ListCity.Add(new CityModel
                {
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting",
                    Location = "Cataratas del Iguazú",
                    Name = "Argentina",
                    Price = 840.00,
                    Rating = 5,
                    Restaurant = true,
                    Type = "New",
                    Umbrella = true,
                    Wifi = true,
                    Worked = true,
                    PathImage = "https://cdn.lavoz.com.ar/sites/default/files/styles/width_2500/public/nota_periodistica/Cataratas_saiko3p_123RF_1587014049.jpg"
                });
                ListCity.Add(new CityModel
                {
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting",
                    Location = "Parque Nacional Natural Tayrona",
                    Name = "Colombia",
                    Price = 640.00,
                    Rating = 4.5,
                    Restaurant = false,
                    Type = "Sale",
                    Umbrella = false,
                    Wifi = true,
                    Worked = false,
                    PathImage = "https://s3-us-west-2.amazonaws.com/denomades/blog/wp-content/uploads/2020/04/10142838/image.jpg"
                });
                ListCity.Add(new CityModel
                {
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting",
                    Location = "Agua Azul",
                    Name = "Mexico",
                    Price = 340.00,
                    Rating = 4.5,
                    Restaurant = false,
                    Type = "New",
                    Umbrella = true,
                    Wifi = false,
                    Worked = true,
                    PathImage = "https://a.travel-assets.com/findyours-php/viewfinder/images/res70/246000/246569-Cascadas-De-Agua-Azul.jpg"
                });
            }
            catch
            {

            }
        }
        #endregion
    }
}
