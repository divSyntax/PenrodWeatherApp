using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace PenrodWeatherApp
{
    public partial class index : Page
    {
        const string AAPID = "452cd8292baf6b9d76d2ec42e2d0972c";
        string[] cities = new string[] {"Milwaukee", "Minneapolis", "Chicago","Dallas" };

        protected void Page_Load(object sender, EventArgs e)
        {
            getMilwaukeeWeather();
            getMinneapolisWeather();
            getChicagoWeather();
            getDallasWeather();
        }

        private void getMilwaukeeWeather()
        {
            //access web pages on new thread
            using (WebClient web = new WebClient())
            {
                //Get api end point for weather
                string Milwaukee = string.Format("http://api.openweathermap.org/data/2.5/weather?q=" + cities[0] + "&appid=" + AAPID + "&units=imperial");

                //download requested source as a string
                var Json = web.DownloadString(Milwaukee);

                //DeserializeObject 
                var objJson = JsonConvert.DeserializeObject<weatherConditions.RootObject>(Json);

                //get weather object
                weatherConditions.RootObject weatherConditions = objJson;
                List<weatherConditions> weathers = new List<weatherConditions>();

                //display weather data
                milwaukeeCity.Text = string.Format("{0} ", objJson.name);
                milwaukeeCountry.Text = string.Format("{0} ", objJson.sys.country);
                milwaukeeTemp.Text = string.Format("{0}", Math.Round(objJson.main.temp));// round degrees to take decimal point off

                //loop through each item in the weather object and get item dec and icon
                foreach (var item in weatherConditions.weather)
                {
                    milwaukeeDesc.Text = string.Format("{0}", item.description);
                    milwImage.ImageUrl = "http://openweathermap.org/img/w/" + item.icon + ".png";
                }
            }
        }

        private void getMinneapolisWeather()
        {
            using (WebClient web = new WebClient())
            {
                //Get api end point for weather
                string Minneapolis = string.Format("http://api.openweathermap.org/data/2.5/weather?q=" + cities[1] + "&appid=" + AAPID + "&units=imperial");
             
                 //download requested source as a string
                var Json = web.DownloadString(Minneapolis);

                //DeserializeObject 
                var objJson = JsonConvert.DeserializeObject<weatherConditions.RootObject>(Json);

                //get weather object
                weatherConditions.RootObject weatherConditions = objJson;
                List<weatherConditions> weathers = new List<weatherConditions>();

                //display weather data
                minneapolisCity.Text = string.Format("{0} ", objJson.name);
                minneapolisCountry.Text = string.Format("{0} ", objJson.sys.country);
                minneapolisTemp.Text = string.Format("{0}", Math.Round(objJson.main.temp));// round degrees to take decimal point off

                //loop through each item in the weather object and get item dec and icon
                foreach (var item in weatherConditions.weather)
                {
                    minniDesc.Text = string.Format("{0}", item.description);
                    minniImage.ImageUrl = "http://openweathermap.org/img/w/" + item.icon + ".png";
                }
            }
        }

        private void getChicagoWeather()
        {
            using (WebClient web = new WebClient())
            {
                //Get api end point for weather
                string Chicago = string.Format("http://api.openweathermap.org/data/2.5/weather?q=" + cities[2] + "&appid=" + AAPID + "&units=imperial");

                 //download requested source as a string
                var Json = web.DownloadString(Chicago);

                //DeserializeObject 
                var objJson = JsonConvert.DeserializeObject<weatherConditions.RootObject>(Json);

                //get weather object
                weatherConditions.RootObject weatherConditions = objJson;
                List<weatherConditions> weathers = new List<weatherConditions>();

                //display weather data
                chicagoCity.Text = string.Format("{0} ", objJson.name);
                chicagoCountry.Text = string.Format("{0} ", objJson.sys.country);
                chicagoTemp.Text = string.Format("{0}", Math.Round(objJson.main.temp));// round degrees to take decimal point off

                //loop through each item in the weather object and get item dec and icon
                foreach (var item in weatherConditions.weather)
                {
                    chiDesc.Text = string.Format("{0}", item.description);
                    chiImage.ImageUrl = "http://openweathermap.org/img/w/" + item.icon + ".png";
                }
            }
        }

        private void getDallasWeather()
        {
                using (WebClient web = new WebClient())
                {
                    //Get api end point for weather
                    string Dallas = string.Format("http://api.openweathermap.org/data/2.5/weather?q=" + cities[3] + "&appid=" + AAPID + "&units=imperial");

                     //download requested source as a string
                    var Json = web.DownloadString(Dallas);

                    //DeserializeObject 
                    var objJson = JsonConvert.DeserializeObject<weatherConditions.RootObject>(Json);

                    //get weather object
                    weatherConditions.RootObject weatherConditions = objJson;
                    List<weatherConditions> weathers = new List<weatherConditions>();

                    //display weather data
                    dallasCity.Text = string.Format("{0} ", objJson.name);
                    dallasCountry.Text = string.Format("{0} ", objJson.sys.country);
                    dallasTemp.Text = string.Format("{0}", Math.Round(objJson.main.temp));// round degrees to take decimal point off

                //loop through each item in the weather object and get item dec and icon
                foreach (var item in weatherConditions.weather)
                    {
                        dallDesc.Text = string.Format("{0}", item.description);
                        dallImage.ImageUrl = "http://openweathermap.org/img/w/" + item.icon + ".png";
                    }

                }     
        }
    }
}