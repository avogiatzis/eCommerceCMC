using System.Collections.Generic;
using Domain;

namespace Persistence
{
    public class DataContext :IDataContext
    {   
        private List<Product> data =new List<Product>(){
            new Product{
                Id=1,
                Name="Black Jean Shearling",
                Category="Jackets",
                Price=125,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            },
            new Product{
                Id=2,
                Name="Blue Jean Jacket",
                Category="Jackets",
                Price=90,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=3,
                Name="Grey Jean Jacket",
                Category="Jackets",
                Price=90,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=4,
                Name="Brown Shearling",
                Category="Jackets",
                Price=165,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=5,
                Name="Tan Trench",
                Category="Jackets",
                Price=90,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=6,
                Name="Blue Beannie",
                Category="Hats",
                Price=10,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=7,
                Name="Black Beannie",
                Category="Hats",
                Price=10,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=8,
                Name="Palm Tree Cap",
                Category="Hats",
                Price=14,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=9,
                Name="Red Beannie",
                Category="Hats",
                Price=10,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=10,
                Name="Wolf Cap",
                Category="Hats",
                Price=125,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=11,
                Name="Black Adidas",
                Category="Sneakers",
                Price=220,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=12,
                Name="White Adidas",
                Category="Sneakers",
                Price=110,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=13,
                Name="Red Nike",
                Category="Sneakers",
                Price=230,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=14,
                Name="Black Nike",
                Category="Sneakers",
                Price=195,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=15,
                Name="All Stars",
                Category="Sneakers",
                Price=130,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=16,
                Name="Red T-Shirt",
                Category="Mens",
                Price=15,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=17,
                Name="Green T-Shirt",
                Category="Mens",
                Price=17,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=18,
                Name="Red Dress",
                Category="Womens",
                Price=125,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=19,
                Name="Floral Dress",
                Category="Womens",
                Price=80,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            },
            new Product{
                Id=20,
                Name="White Blouse",
                Category="Womens",
                Price=20,
                Image="https://marketplace.canva.com/MADGxyhjdcM/4/screen_2x/canva-business-shoes-on-wood-floor-MADGxyhjdcM.jpg"
            
            }
        };
        public List<Product> Products(){
            return data;
        }
    }
}