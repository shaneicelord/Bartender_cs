using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Bartender_cs.Models
{
    public class Cocktail
    {
        SqlConnection connection = new SqlConnection();
        List<Cocktail> CocktailList = new List<Cocktail>();

        public String DrinkName { get; set; }
        public String DrinkIngredients { get; set; }
        public double DrinkPrice { get; set; }

        Cocktail drink = null;

        public List<Cocktail> GetCocktail()
        {
            connection.ConnectionString = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=BartenderAppData;Integrated Security=True";

            connection.Open();

            using (connection)
            {
                SqlCommand cmd = new SqlCommand("Select * from Cocktails", connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    drink = new Cocktail();
                    drink.DrinkName = Convert.ToString(reader.GetSqlValue(0));
                    drink.DrinkIngredients = Convert.ToString(reader.GetSqlValue(1));
                    drink.DrinkPrice = Convert.ToDouble(reader.GetSqlValue(2));

                    CocktailList.Add(drink);
                }
            }

            if(!CocktailList.Any())
            {
                drink = new Cocktail();
                drink.DrinkName = "Ripper";
                drink.DrinkIngredients = "Coconut rum, Pineapple juice, Cherry";
                drink.DrinkPrice = 5.00;

                CocktailList.Add(drink);
            }

            return CocktailList;
        }
        
        
    }
}