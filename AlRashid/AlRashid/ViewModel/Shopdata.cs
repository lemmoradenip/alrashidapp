using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
namespace AlRashid.ViewModel
{
    public class Shopdata
    {
        public Shopdata()
        {
        }
        public IEnumerable<Shop> GetShops(string searchtext = null)
        {
            string Imageurl = "https://web.artar.com.sa/images/apps/{0}";
            string Bannerurl = "http://www.artar.com.sa/administration/upl/small/ci_img_15.jpg";
            //add the program to fetch items here
            var shoplist = new List<Shop>
            {
                new Shop{Name="Advance Food(test)",Description="Test Description", Category="A",LogoImageUrl="https://web.artar.com.sa/images/logo1.png",ImageUrl=Bannerurl,Mobile="+966xxxxxx1",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="B Test Shop B",Description="Test Description", Category="B",LogoImageUrl=String.Format(Imageurl,"2")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx2",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="C Test Shop C",Description="Test Description", Category="C",LogoImageUrl=String.Format(Imageurl,"3")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx3",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="B Test Shop B",Description="Test Description", Category="B",LogoImageUrl=String.Format(Imageurl,"2")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx2",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="C Test Shop C",Description="Test Description", Category="C",LogoImageUrl=String.Format(Imageurl,"3")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx3",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="B Test Shop B",Description="Test Description", Category="B",LogoImageUrl=String.Format(Imageurl,"2")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx2",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="C Test Shop C",Description="Test Description", Category="C",LogoImageUrl=String.Format(Imageurl,"3")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx3",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="B Test Shop B",Description="Test Description", Category="B",LogoImageUrl=String.Format(Imageurl,"2")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx2",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="C Test Shop C",Description="Test Description", Category="C",LogoImageUrl=String.Format(Imageurl,"3")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx3",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="B Test Shop B",Description="Test Description", Category="B",LogoImageUrl=String.Format(Imageurl,"2")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx2",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="C Test Shop C",Description="Test Description", Category="C",LogoImageUrl=String.Format(Imageurl,"3")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx3",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}

            };

            if (String.IsNullOrWhiteSpace(searchtext))
                return shoplist;

            return shoplist.Where(c => c.Name.StartsWith(searchtext)); //.Where(c => c.Name.StartWith(searchtext));

        }

        public IEnumerable<Shop> GetFilteredShops(string searchtext = null)
        {
            string Imageurl = "https://web.artar.com.sa/images/apps/{0}";
            string Bannerurl = "http://www.artar.com.sa/administration/upl/small/ci_img_15.jpg";
            //add the program to fetch items here
            var shoplist = new List<Shop>
            {
                 new Shop{Name="Advance Food(test)",Description="Test Description", Category="A",LogoImageUrl="https://web.artar.com.sa/images/logo1.png",ImageUrl=Bannerurl,Mobile="+966xxxxxx1",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="B Test Shop B",Description="Test Description", Category="B",LogoImageUrl=String.Format(Imageurl,"2")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx2",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="C Test Shop C",Description="Test Description", Category="C",LogoImageUrl=String.Format(Imageurl,"3")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx3",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="B Test Shop B",Description="Test Description", Category="B",LogoImageUrl=String.Format(Imageurl,"2")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx2",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="C Test Shop C",Description="Test Description", Category="C",LogoImageUrl=String.Format(Imageurl,"3")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx3",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="B Test Shop B",Description="Test Description", Category="B",LogoImageUrl=String.Format(Imageurl,"2")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx2",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="C Test Shop C",Description="Test Description", Category="C",LogoImageUrl=String.Format(Imageurl,"3")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx3",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="B Test Shop B",Description="Test Description", Category="B",LogoImageUrl=String.Format(Imageurl,"2")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx2",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="C Test Shop C",Description="Test Description", Category="C",LogoImageUrl=String.Format(Imageurl,"3")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx3",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="B Test Shop B",Description="Test Description", Category="B",LogoImageUrl=String.Format(Imageurl,"2")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx2",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}
                ,new Shop{Name="C Test Shop C",Description="Test Description", Category="C",LogoImageUrl=String.Format(Imageurl,"3")+".png",ImageUrl=Bannerurl,Mobile="+966xxxxxx3",Telephone="966 11 211 2202",Email="noemail@email.com",Website="www.nosite.com"}

            };


            if (String.IsNullOrWhiteSpace(searchtext))
                return shoplist;

            return shoplist.Where(c => c.Category.Equals(searchtext)); //.Where(c => c.Name.StartWith(searchtext));

        }


    }
}
