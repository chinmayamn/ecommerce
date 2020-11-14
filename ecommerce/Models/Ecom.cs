using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerce.Models
{
    public class Ecom
    {

    }
    public class Products
    {
        private int id;
        private string name;
        private string image;
        private string category;
        private string price;
        private string discount;
        private string rating;
        private string desc;
/*
        public Products(int id, string name, string prodimage, string category, string price, string discount, string rating, string description)
        {
            this.id = id;
            this.name = name;
            this.prodimage = prodimage;
            this.category = category;
            this.price = price;
            this.discount = discount;
            this.rating = rating;
            this.description = description;
        }*/

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Image { get => image; set => image = value; }
        public string Category { get => category; set => category = value; }
        public string Price { get => price; set => price = value; }
        public string Discount { get => discount; set => discount = value; }
        public string Rating { get => rating; set => rating = value; }
        public string ProdDesc { get => desc; set => desc = value; }
    }
}