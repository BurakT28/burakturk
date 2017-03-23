using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace XamarinAllianceApp.Models
{
    public class Character
    {
        Int32 id;
        Int32 year;
        string name;
        string leadcharacter;
        string info;
        float height;
        string imageurl;
        ICollection<Weapon> weapons;
        ICollection<Movie> appearances;

        [JsonProperty(PropertyName = "id")]
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "year")]
        public Int32 Year
        {
            get { return year; }
            set { year = value; }
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty(PropertyName = "info")]
        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        [JsonProperty(PropertyName = "leadcharacter")]
        public string Leadcharacter
        {
            get { return leadcharacter; }
            set { leadcharacter = value; }
        }

        [JsonProperty(PropertyName = "height")]
        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        [JsonProperty(PropertyName = "imageurl")]
        public string Imageurl
        {
            get { return imageurl; }
            set { imageurl = value; }
        }

        [JsonProperty(PropertyName = "weapons")]
        public ICollection<Weapon> Weapons
        {
            get { return weapons; }
            set { weapons = value; }
        }

        [JsonProperty(PropertyName = "appearances")]
        public ICollection<Movie> Appearances
        {
            get { return appearances; }
            set { appearances = value; }
        }

        public string Version { get; set; }
    }
}
