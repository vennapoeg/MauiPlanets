using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class PlanetsServices
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest " +
                "in the Solar System. In English, it is named after the ancient Roman god " +
                "Mercurius (Mercury), god of commerce and communication, and the messenger " +
                "of the gods. Mercury is classified as a terrestrial planet, with roughly " +
                "the same surface gravity as Mars. The surface of Mercury is heavily " +
                "cratered, as a result of countless impact events that have accumulated " +
                "over billions of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://external-preview.redd.it/Pl5aSNxMB5u_M_fBRI0XKCAG8t3j1tWNf0N6hE5iJ0s.jpg?width=1080&crop=smart&auto=webp&s=f6c375e3baa9d092b363494180238c9483f28cdb",
                    "https://www.suse.com/c/wp-content/uploads/2023/07/Mercury_JeffR-1024x576.jpg",
                    "https://ichef.bbci.co.uk/ace/standard/976/cpsprodpb/115C8/production/_88621117_88621116.jpg.webp"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description ="Venus is the second planet from the Sun. It is a terrestrial " +
                "planet and is the closest in mass and size to its orbital neighbour" +
                " Earth. Venus has by far the densest atmosphere of the terrestrial " +
                "planets, composed mostly of carbon dioxide with a thick, global " +
                "sulfuric acid cloud cover. At the surface it has a mean temperature " +
                "of 737 K (464 °C; 867 °F) and a pressure 92 times that of Earth's " +
                "at sea level.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life " +
                "exists. Almost 1.5 million species of animals and plants have been " +
                "discovered so far, and many more have yet to be found. While " +
                "other planets may have small amounts of ice or steam, the Earth " +
                "is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/0/02/OSIRIS_Mars_true_color.jpg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://ichef.bbci.co.uk/images/ic/1376xn/p0257vwk.jpg.webp",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "The famous dwarf planet",
                HeroImage = "pluto.png",
                Description = "Pluto is a dwarf planet in the Kuiper Belt, a donut-shaped region of icy bodies beyond Neptune. Once considered the ninth planet, Pluto is now recognized as the largest dwarf planet in this distant region of our solar system.",
                AccentColorStart = Color.FromArgb("#3b3f5c"),
                AccentColorEnd = Color.FromArgb("#8fa0c2"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/C7G6hzMza8PsxLewoioy3a-1200-80.jpg.webp",
                    "https://cdn.mos.cms.futurecdn.net/xngmDgmf7JyPwMW9n8uHL8-1200-80.jpg.webp",
                    "https://upload.wikimedia.org/wikipedia/commons/9/94/Pluto-transparent.png",
                    "https://cdn.mos.cms.futurecdn.net/8tRVfa2VMaCkNKr7HpTHWA-1200-80.jpg.webp"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "Queen of the asteroid belt",
                HeroImage = "ceres.png",
                Description = "Ceres is the largest object in the asteroid belt between Mars and Jupiter. It is also the first dwarf planet visited by a spacecraft and the only one located in the inner solar system.",
                AccentColorStart = Color.FromArgb("#4b4b4b"),
                AccentColorEnd = Color.FromArgb("#8d8d8d"),
                Images = new()
                {
                    "https://www.pbs.org/wgbh/nova/media/images/Occator_Crater.width-990_ib0gbRs.jpg",
                    "https://i.extremetech.com/imagery/content-types/00MWOGDO3ZKZT2KzInwFP7O/images-2.jpg",
                    "https://www.americaspace.com/wp-content/uploads/2015/12/PIA20186-640x350.jpg"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The oval dwarf",
                HeroImage = "haumea.png",
                Description = "Haumea is an elongated dwarf planet located in the Kuiper Belt. It is known for its unusual stretched shape, rapid rotation, and faint ring system.",
                AccentColorStart = Color.FromArgb("#354c4e"),
                AccentColorEnd = Color.FromArgb("#6ba2a5"),
                Images = new()
                {
                    "https://cdn.sci.news/images/2022/10/image_11303-Haumea.jpg",
                    "https://c02.purpledshub.com/uploads/sites/48/2024/01/dwarf-planet-haumea-rings.jpg?fit=800%2C445&webp=1&w=1200",
                    "https://static.scientificamerican.com/sciam/cache/file/4755510F-DAE7-4D87-A5BC0FE719A18342_source.jpg?w=1350"
                }
            },
            new()
            {
                Name = "Makemake",
                Subtitle = "The bright Kuiper Belt dwarf",
                HeroImage = "makemake.png",
                Description = "Makemake is one of the largest known objects in the Kuiper Belt. It has a bright surface covered with methane ice and was discovered shortly after Eris.",
                AccentColorStart = Color.FromArgb("#4c3a21"),
                AccentColorEnd = Color.FromArgb("#b57f50"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/nFpPhcD3CzvCkYtr8YXqJX-967-80.jpg.webp",
                    "https://cdn.shopify.com/s/files/1/0742/7719/1954/files/Makemake_1024x1024.jpg?v=1693092886",
                    "https://theplanets.org/123/2021/11/Dwarf-Planet-Makemake.png"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "Pluto’s icy rival",
                HeroImage = "eris.png",
                Description = "Eris is a massive dwarf planet located in the scattered disk region beyond the Kuiper Belt. Its discovery was one of the major reasons Pluto lost its status as a full planet.",
                AccentColorStart = Color.FromArgb("#3d3d3d"),
                AccentColorEnd = Color.FromArgb("#8ca7c7"),
                Images = new()
                {
                    "https://www.universetoday.com/article_images/2007-0613eris.jpg",
                    "https://www.scienceabc.com/wp-content/uploads/2020/01/Eris-dwarf-planet-in-the-outer-spaceLarichs.jpg",
                    "https://www.scienceabc.com/wp-content/uploads/2020/01/Artists-impression-dwarf-planet-Eris.jpg"
                }
            },

        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}