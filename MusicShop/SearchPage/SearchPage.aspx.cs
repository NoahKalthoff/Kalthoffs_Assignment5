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
                MyStaticValues.genreIds = dbcon.Genres.Select(ids => ids.GenreID).ToArray();
                MyStaticValues.genreNames = dbcon.Genres.Select(names => names.GenreName).ToArray();

                DropDownList1.DataSource = MyStaticValues.genreNames;
                DropDownList1.DataBind();
            }
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (dbcon = new MusicShopDataContext(connString))
            {
                int selectedID = MyStaticValues.genreIds[DropDownList1.SelectedIndex];

                MyStaticValues.artistNames = dbcon.Artists.Where(artist => artist.GenreID == selectedID).Select(artist => artist.ArtistName).ToArray();

                DropDownList1.SelectedIndex = DropDownList1.SelectedIndex;
                DropDownList2.DataSource = MyStaticValues.artistNames;
                DropDownList2.DataBind();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
        }
    }
}