using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicShop.SearchPage
{
    public partial class SearchPage : System.Web.UI.Page
    {
        MusicShopDataContext dbcon;
        string connString = MyStaticValues.conn;
        int test = 1;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // orignal connString declared in global.asax.cs
            


            using (dbcon = new MusicShopDataContext(connString))
            {
                // Correlated Ids and Names have same array position
                var queryResult1 = (from x in dbcon.Genres
                                    select x.GenreName);
                
                DropDownList1.DataSource = queryResult1.ToList();
                DropDownList1.DataBind();
            }
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (dbcon = new MusicShopDataContext(connString))
            {
                string selectedGenre = DropDownList1.SelectedIndex.ToString();

                var queryResult2 = (from x in dbcon.Genres
                                    where x.GenreName == selectedGenre
                                    select x.GenreID);
                var queryResult3 = (from x in dbcon.Artists
                                    where x.GenreID == queryResult2.Max()
                                    select x.ArtistName);

                DropDownList2.DataSource = queryResult3.ToList();
                DropDownList2.DataBind();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
        }
    }
}