using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDrink.WebUI.Data.Models
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink
                    {
                        Name = "Bira",
                        Price = 140.75M,
                        ShortDescription = "En çok tüketilen alkol",
                        LongDescription = "Bira dünyanın en eski ve en yaygın tüketilen alkollü içeceğidir; su ve çaydan sonra genel olarak en popüler üçüncü içecektir.Bira üretimi, buğday, mısır (mısır) ve pirinç yaygın olarak kullanılmasına rağmen, çoğunlukla malt arpa gibi tahıl tanelerinden elde edilen nişastaların fermantasyonunu içeren biracılık olarak adlandırılır. [6] Çoğu bira, acılık katan ve doğal bir koruyucu görevi gören şerbetçiotu ile tatlandırılır, ancak bazen otlar veya meyveler gibi diğer tatlandırıcılar da dahil edilebilir. Fermantasyon süreci doğal bir karbonatlaşma etkisine neden olur, ancak bu genellikle işleme sırasında çıkarılır ve yerine zorunlu karbonatlaşma uygulanır.[7] İnsanlığın bilinen en eski yazılarından bazıları bira üretimi ve dağıtımına atıfta bulunur: Hammurabi Kanunları bira ve birahaneleri düzenleyen yasalar içeriyordu.",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://www.hukins-hops.co.uk/wp-content/uploads/2024/04/what-is-the-percentage-alcohol-in-beer.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://minuman.com/cdn/shop/articles/Everything-You-Need-to-Know-About-Beer-2.jpg"
                    },
                    new Drink
                    {
                        Name = "Rom ve Kola",
                        Price = 105.95M,
                        ShortDescription = "Kola, misket limonu ve romdan yapılan kokteyl.",
                        LongDescription = "Dünyanın en popüler ikinci içkisi Amerika Birleşik Devletleri ve İspanya arasındaki bir çarpışmada doğdu. Olay, yüzyılın başında İspanya-Amerika Savaşı sırasında Teddy Roosevelt, Rough Riders ve çok sayıda Amerikalı Küba'ya geldiğinde meydana geldi. Bir öğleden sonra, ABD Muhabere Birliği'nden bir grup izinli asker Eski Havana'da bir barda toplanır. Genç bir haberci olan Fausto Rodriguez daha sonra Yüzbaşı Russell'ın içeri girdiğini ve Bacardi (Gold) romu ile buzlu Coca-Cola ve bir dilim limon sipariş ettiğini hatırladı. Yüzbaşı bu karışımı öylesine keyifle içmiş ki, etrafındaki askerlerin de ilgisini çekmiş. Barmene kendileri için yüzbaşının içkisinden bir tur hazırlattılar. Bacardi romu ve kola anında hit oldu. Bugün de olduğu gibi, bu içki kalabalığı eğlence ve dostluk ruhu içinde birleştirdi. Bir tur daha sipariş ettiklerinde, bir asker yeni özgürlüğüne kavuşan Küba'yı kutlamak için ¡Por Cuba Libre! şerefine kadeh kaldırmalarını önerdi.",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://media.diageocms.com/eyJrZXkiOiJtZWRpYS9tNHNua2Z4eS9iYXJjb21fc2VydmVfaW1hZ2VfMTU0MDc2MF9jYXB0YWlubW9yZ2FucnVtY29sYS5qcGciLCJlZGl0cyI6eyJyZXNpemUiOnsiaGVpZ2h0Ijo2MTAsIndpZHRoIjo2MTB9fX0=",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://thegastromagazine.com/wp-content/uploads/2023/05/How-To-Make-A-Bubbly-And-Refreshing-Rum-Cola-Cocktail.jpg"
                    },
                    new Drink
                    {
                        Name = "Tekila ",
                        Price = 89.95M,
                        ShortDescription = "Mavi agave bitkisinden yapılan içecek.",
                        LongDescription = "Tekila (İspanyolca Bu ses hakkında [teˈkila] (help-info)), öncelikle Guadalajara'nın 65 km (40 mil) kuzeybatısındaki Tequila şehrini çevreleyen alanda ve orta batı Meksika eyaleti Jalisco'nun dağlık bölgelerinde (Los Altos) mavi agave bitkisinden yapılan damıtılmış bir içeceğin bölgesel olarak özel bir adıdır. Tekila mezkalaya benzemekle birlikte, modern tekila üretim yöntemi, sadece mavi agave bitkilerinin kullanılması ve bölgesel özgünlüğü bakımından biraz farklılık gösterir. Tekila Meksika'da genellikle sek olarak, dünyanın geri kalanında ise tuz ve misket limonu ile shot olarak servis edilir. Çevredeki kırmızı volkanik toprak mavi agav yetiştirmek için özellikle uygundur ve her yıl 300 milyondan fazla bitki hasat edilmektedir. Los Altos dağlık bölgesinde yetişen mavi agavların boyutları daha büyük, aroma ve tatları daha tatlıdır. Ovalarda hasat edilen agavlar ise daha otsu bir koku ve tada sahiptir.",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://www.gurmerehberi.com/wp-content/uploads/2021/10/Bir-Tequila-Sour-kokteyli-klasik-ve-zarif-bir-sunumla.-Kokteyl-5-cl-tequila-3-cl-taze-sikilmis-limon-suyu-ve-15-cl-seker-surubu-karisimindan-olusu.png",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://olmecaaltos.com/wp-content/uploads/2024/02/fake-tequila-1.webp"
                    },
                    new Drink
                    {
                        Name = "Meyve Suyu",
                        Price = 52.75M,
                        ShortDescription = "Meyve veya sebze dokusunda doğal olarak bulunur.",
                        LongDescription = "Meyve suyu, meyve ve sebzelerde bulunan doğal sıvının ekstraksiyonundan veya preslenmesinden elde edilen bir içecektir. Aynı zamanda konsantre veya istiridye suyu gibi et veya deniz ürünleri gibi diğer biyolojik gıda kaynakları ile tatlandırılmış sıvıları da ifade edebilir. Meyve suyu genellikle bir içecek olarak tüketilir veya gıdalarda ya da smoothie gibi diğer içeceklerde bir bileşen veya tatlandırıcı olarak kullanılır. Meyve suyu, pastörizasyon yöntemlerinin geliştirilmesinden sonra fermantasyon (şarap üretiminde kullanılan) kullanılmadan muhafaza edilmesini sağlayan popüler bir içecek seçeneği olarak ortaya çıkmıştır. En büyük meyve suyu tüketicileri Yeni Zelanda (her gün yaklaşık bir fincan veya 8 ons) ve Kolombiya'dır (her gün bir fincanın dörtte üçünden fazlası). Meyve suyu tüketimi ortalama olarak bir ülkenin gelir seviyesiyle birlikte artmaktadır.",
                        Category = Categories["Alkolsüz"],
                        ImageUrl = "https://fruitjuicesciencecentre.eu//storage/files/269fa21f-e822-44c0-ae21-fecbebb22cf3/header_green_small_5-reasons.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://product.hstatic.net/200000325223/product/8-08_8bdce2f395364fa9a1ef7b3f2e0fb571_master.png"
                    },
                    new Drink
                    {
                        Name = "Margarita",
                        Price = 175.95M,
                        ShortDescription = "Sek, tekila ve misket limonlu bir kokteyl.",
                        Category = Categories["Alkollü"],
                        LongDescription = "Margarita, tekila , triple sec ve limon suyundan oluşan bir kokteyldir. Bazı margarita tarifleri basit şurup da içerir ve genellikle bardağın ağzında tuzla servis edilir. Margaritalar buzla çalkalanarak (buzlu), buzsuz (düz) veya buzla karıştırılarak (dondurulmuş margarita) servis edilebilir. Çoğu bar margaritaları, margarita bardağı adı verilen kokteyl bardağı veya şampanya kadehinin basamaklı çaplı bir çeşidinde servis eder. Margarita, dünyanın en popüler kokteyllerinden biri ve en popüler tekila bazlı kokteyldir.",
                        ImageUrl = "https://assets.bonappetit.com/photos/5b69f16006027f654a27cd19/3:2/w_3693,h_2462,c_limit/ba-margarita-1.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://assets.bonappetit.com/photos/5b69f16006027f654a27cd19/3:2/w_3693,h_2462,c_limit/ba-margarita-1.jpg"
                    },
                    new Drink
                    {
                        Name = "Buzlu Viski",
                        Price = 125.35M,
                        ShortDescription = "Viskiyi tatmanın en iyi yolu.",
                        LongDescription = "Buz bir filtre görevi görür. Damağı hafifçe uyuşturarak, viski daha ferahlatıcı hale gelirken daha sert tatlar atlanır. Burbonda bu özellikle mantıklıdır, doğal güçlü tatlılığı buzla vurgulanır ve diğer unsurlar filtrelenir.",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://topwhiskies.com/cdn/shop/articles/should-you-have-whisky-with-ice.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://topwhiskies.com/cdn/shop/articles/should-you-have-whisky-with-ice.jpg"
                    },
                    new Drink
                    {
                        Name = "Jägermeister",
                        Price = 61.15M,
                        ShortDescription = "Tam 56 bitki ile yapılan bir Alman digestifi",
                        LongDescription = "Jägermeister, Alman yapımı geleneksel Kräuterlikör olarak adlandırılan bir likör türüdür. 56 çeşit bitki ve baharattan elde edilen bir karışım olan içki, hazımı kolaylaştırıcı etkisi ve mide rahatsızlıklarını gidermesi ile ün almıştır. Kokteyl içkisi olarak da kullanılmaktadır. %35 alkol oranı ve koyu kahverengi bir renge sahiptir.Bitkiler ve baharatlar 2-3 gün boyunca suda ıslatılır. Daha sonra bu karışım süzülür ve 1 yıla yakın bir süre meşe fıçılarda bekletilir. Sürenin sonunda tekrar süzülen içki şeker, karamel, alkol ve su ile karıştırılır.İlk üretimi 1935 yılında yapılmıştır. İçkinin üretimi, Mast-Jägermeister AG şirketi tarafından Wolfenbüttel, Braunschweig, Almanya'da gerçekleştirilmektedir. İçkinin içeriğinde geyik ve dağ keçisi kanı olduğu ise bir şehir efsanesidir",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://keyiflobisi.com/wp-content/uploads/2023/01/jagermeister.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://keyiflobisi.com/wp-content/uploads/2023/01/jagermeister.jpg"
                    },
                    new Drink
                    {
                        Name = "Şampanya",
                        Price = 155.55M,
                        ShortDescription = "Köpüklü şarap bu şekilde adlandırılabilir.",
                        LongDescription = "Şampanya, ismini Fransa'nın Champagne şarapçılık bölgesinden alan bir köpüklü beyaz şarap türü. Şampanya genel kullanımda tüm köpüklü şarapları kastetmek için kullanılmakla birlikte, Avrupa Birliği ve diğer bazı ülkelerde Fransa'nın Champagne bölgesinde üretilmeyen köpüklü şarapların Şampanya adı altında etiketlenmesi yasadışıdır. Şampanya genellikle beyaz ve kırmızı üzümlerin kupajından üretilir.",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://www.datocms-assets.com/20941/1666196073-everything-you-need-to-know-about-champagne.png",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://www.datocms-assets.com/20941/1666196073-everything-you-need-to-know-about-champagne.png"
                    },
                    new Drink
                    {
                        Name = "Rakı ",
                        Price = 225.35M,
                        ShortDescription = "Anason aromalı,geleneksel bir Türk içkisidir.",
                        LongDescription = "Anadolu coğrafyasında bu isimlerle belgelenebilen en eski rakı üretimi ve ticareti 15. yüzyılda Trabzon civarından yazılı kayıtlara girmiştir.Rakı ticaretinden bahseden en eski ikinci yazılı kayıt ise 1520 tarihli bir Osmanlı Vergi Nizamnamesidir. Bu belgede de diğerinde olduğu gibi Trabzon, rakının üretildiği ve diğer bölgelere sevk edildiği yer olarak gösterilir.Osmanlı Devleti'nin son dönemlerinde Rumeli'deki gayrimüslim tebaa tarafından da üretilmeye başlanmış ve zamanla tüm Osmanlı coğrafyasında yaygın olarak kullanılan bir içki haline gelmiştir. 19. yüzyıla gelindiğinde ise gayrimüslimlerin çalıştırdığı meyhanelerde en popüler içki olmuştur.",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://imgyukle.com/i/CsvQZ8",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://imgyukle.com/i/CsvQZ8"
                    },
                    new Drink
                    {
                        Name = "White Russian",
                        Price = 85.55M,
                        ShortDescription = "Votka ile yapılan bir kokteyl",
                        LongDescription = "Tüm kokteyllerde olduğu gibi, belirli barların veya barmenlerin tariflerine ve tarzlarına göre değişkenlik gösteren çeşitli hazırlama yöntemleri bulunmaktadır. En yaygın değişiklikler, votka ya da kahve likörü miktarlarının değiştirilmesiyle veya farklı kahve likörü markalarının karıştırılmasıyla oluşturulur. Kremayı koyulaştırmak için içeceğin üzerine dökmeden önce çalkalamak da yaygın bir yöntemdir. Bazen soğuk günlerde sıcak bir içecek olarak kullanmak için ocakta sıcak kahve ile hazırlanmaktadır. Sıcak günlerde ise tam tersini yaparak kokteyli dondurmak için krema yerine vanilyalı dondurmanın kullanıldığı da bilinmektedir.",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/white_russian_36079_16x9.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/white_russian_36079_16x9.jpg"
                    },
                    new Drink
                    {
                        Name = "Long Island Buzlu Çayı",
                        Price = 45.95M,
                        ShortDescription = "Tekila ile yapılan karışık bir içki.",
                        LongDescription = "Long Island iced tea veya Long Island ice tea; genellikle votka, tekila, rom, cin, portakal likörü ve kola karışımıyla oluşturulan ve renginin soğuk çaya benzemesinden ötürü iced tea olarak adlandırılan bir kokteyl türüdür. Pek çok farklı içki türünün karışımından oluşması ve eklenen alkolsüz malzemelerin miktarının az olmasından dolayı yaklaşık yüzde 22 ile pek çok kokteyl çeşidine göre nispeten yüksek bir alkol oranına sahiptir.",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/long_island_iced_tea_42582_16x9.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/long_island_iced_tea_42582_16x9.jpg"
                    },
                    new Drink
                    {
                        Name = "Votka",
                        Price = 185.05M,
                        ShortDescription = "Su ve etanol ile damıtılmış bir içecek.",
                        LongDescription = "Votka veya orijinal ismiyle Vodka (Lehçe: wódka Lehçe telaffuz: [ˈvutka], Rusça: водка Rusça telaffuz: [ˈvotkə]), Polonya ve Rusya menşeli, farklı çeşitlere sahip, şeffaf bir distile alkollü içkidir. Temelde su ve rektifiye etanolden oluşur, bazı diğer maddeler ve aroma izleri bulunabilir. Geleneksel olarak, fermente edilmiş tahıl tanelerinden veya patateslerden elde edilen sıvının damıtılmasıyla yapılır, ancak bazı modern markalar temel olarak meyve veya şeker kullanır. Özel bir tat ve kokusu yoktur ve renksizdir. İsminin Slavca su anlamına gelen voda (woda, вода)'dan geldiği sanılmaktadı",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://miraclesrc.com/wp-content/uploads/2024/01/vodka.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://miraclesrc.com/wp-content/uploads/2024/01/vodka.jpg"
                    },
                    new Drink
                    {
                        Name = "Cin Tonik",
                        Price = 135.75M,
                        ShortDescription = "Buz üzerine dökülen cin ve tonik su ile yapılır.",
                        LongDescription = "Cin ve tonik veya halk arasında Cin tonik, büyük miktarda buzun üzerine dökülerek yapılan bir highball (alkollü+alkolsüz içecek) kokteylidir. Cin tonik oranı tada, cinin kuvvetine, eklenen diğer içeceklerin oranına göre değişir. Genellikle bir dilim veya parça limon dilimi ile süslenir. Efervesansı korumak için tonik bir bar kaşığına dökülebilir. Buz, cini soğuk tutar, alkolün ağızdaki etkisini azaltır ve içeceği daha keyifli hale getirir.",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://www.allrecipes.com/thmb/0PKbNBTJeI2Dj61kRDo6S1hx1Hs=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/Gin-and-Tonic-Jennifer-Baker-2000-e3eeedfb409943999111b40d68a787ca.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://www.allrecipes.com/thmb/0PKbNBTJeI2Dj61kRDo6S1hx1Hs=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/Gin-and-Tonic-Jennifer-Baker-2000-e3eeedfb409943999111b40d68a787ca.jpg"
                    },
                    new Drink
                    {
                        Name = "Cosmopolitan",
                        Price = 70.25M,
                        ShortDescription = "Votka, triple sec, kızılcık suyu ile yapılmıştır.",
                        LongDescription = "Uluslararası Barmenler Birliği tarifi, limon aromalı votka olan turunçgil votkasına dayanmaktadır. Bu kokteylin temeli olarak turunçgil aromalı votkanın kullanımı, 1990'ların ortalarında kokteyl uzmanı Dale DeGroff  tarafından yaygın olarak popüler hale getirilmiş gibi görünüyor ve UBB onaylı tarifte yer alıyor. Bununla birlikte, birçok barmen standart aromasız votka kullanmaya devam ediyor - bu alternatif şüphesiz 1970'lerde Ohio, Provincetown veya Minneapolis'te veya 1980'lerde San Francisco'da popüler olan bu içeceğin varsayılan öncüllerinden herhangi biriyle tarihsel olarak tutarlı olacaktır. Bazen süslemek için limon kabuğu kullanılır.",
                        Category = Categories["Alkollü"],
                        ImageUrl = "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/cosmopolitan_88567_16x9.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/cosmopolitan_88567_16x9.jpg"
                    },
                    new Drink
                    {
                        Name = "Çay",
                        Price = 10.00M,
                        ShortDescription = "Çay bitkisinin yapraklarının sıcak suda bekletilmesiyle elde edilir.",
                        LongDescription = "Hindistan, Sri Lanka, Çin, Türkiye, Kenya, Endonezya, Malavi ve Vietnam dünyada en önde gelen çay üretici ülkeleri oluşturur. Türkiye'de çay, sadece Gürcistan sınırından başlayan ve Fatsa'ya kadar uzanan alan içerisinde yetiştirilebilmektedir. Türkiye'de yaygın olarak çay, Doğu Karadeniz bölgesinden toplanır ve çay yapraklarından yapılan kırmızı renkteki içecek için kullanılır.",
                        Category = Categories["Alkolsüz"],
                        ImageUrl = "https://i.lezzet.com.tr/images-xxlarge-secondary/cayin-tarihcesi-ve-turkiyeye-gelisi-c812539d-a158-4205-b031-724dd2fe3530",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://i.lezzet.com.tr/images-xxlarge-secondary/cayin-tarihcesi-ve-turkiyeye-gelisi-c812539d-a158-4205-b031-724dd2fe3530"
                    },
                    new Drink
                    {
                        Name = "Su",
                        Price = 10.00M,
                        ShortDescription = "Vücut ağırlığınızın yarısından fazlasını oluşturur.",
                        LongDescription = "Su, Dünya üzerinde bol miktarda bulunan ve tüm canlıların yaşaması için vazgeçilmez olan, kokusuz ve tatsız bir kimyasal bileşiktir.[4] Sıklıkla renksiz olarak tanımlanmasına rağmen kızıl dalga boylarında ışığı hafifçe emmesi nedeniyle mavi bir renge sahiptir.",
                        Category = Categories["Alkolsüz"],
                        ImageUrl = "https://elmaciksu.com.tr/wp-content/uploads/2020/09/elmaciksu-cunku-dogal-mineralli.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://elmaciksu.com.tr/wp-content/uploads/2020/09/elmaciksu-cunku-dogal-mineralli.jpg"
                    },
                    new Drink
                    {
                        Name = "Türk Kahvesi",
                        Price = 100.55M,
                        ShortDescription = "Geleneksel sıcak bir Türk içeceğidir.",
                        LongDescription = "Türk kahvesi her ne kadar Türkiye’ye özgü bir kahve olarak bilinse de esasında çekirdek olarak farklı bölgelerin çekirdeklerinden elde edilmektedir. Türk kahvesi sadece demleme -pişirme- yöntemi ile bu ismi almaktadır. Türk kahvesi özellikle bol köpüklü olması ile diğer kahvelerden ayrılmakta, bu yüzden yaygın şekilde tüketilen bir tadıma ve aromaya sahip olmaktadır. Türk kahvesi esas itibariyle espresso gibi küçük miktarlarda içiliyor olsa da içim şekli ile farklılaşmaktadır. Espresso kısa içime sahipken Türk kahvesi oldukça uzun soluklu bir içime sahip kahvedir. En ince öğütüm ayarına sahip olması ile de diğer kahvelerden ayrılan Türk kahvesi için farklı kahve çekirdekleri ile demlemeler yapılabilmektedir. Türk kahvesine uygun yöresel çekirdekler ile birlikte farklı bir Türk kahvesi deneyimi yaşamak mümkün hale gelmektedir.",
                        Category = Categories["Alkolsüz"],
                        ImageUrl = "https://coffeetropic.com/wp-content/uploads/2020/05/turk-kahvesi.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://coffeetropic.com/wp-content/uploads/2020/05/turk-kahvesi.jpg"
                    },
                    new Drink
                    {
                        Name = "Kvass",
                        Price = 122.35M,
                        ShortDescription = "Çok ferahlatıcı bir Rus içeceği.",
                        LongDescription = "Orijinal Kvas çavdar ekmeğiyle yapılsa da, buğday ya da arpa ekmeklerinin mayalanmasıyla da üretilmektedir. Üretiminde üzümsü meyveler, çilek ve huş ağacı usaresi aromatik bileşen olarak kullanılabilmektedir. Modern ev yapımı Kvas çoğunlukla küçük doğranmış ve fırınlanarak kurutulmuş Suhari adı verilen esmer ya da normal çavdar ekmeği, şeker ve aromatik olarak da meyve ya da kuru üzüm eklenerek yapılmaktadır. Üretim sırasında bu bileşenlere maya kültürü ve Zakvaska adı verilen mayalanma başlatıcısı eklenir.",
                        Category = Categories["Alkolsüz"],
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/97/Mint_bread_kvas.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/9/97/Mint_bread_kvas.jpg"
                    },
                    new Drink
                    {
                        Name = "Soda",
                        Price = 15.55M,
                        ShortDescription = "Sodalı su ya da karbonatlı su.",
                        LongDescription = "Soda, sodalı su ya da karbonatlı su; içinde çözülmüş halde karbondioksit gazı bulunan su. Çoğu meşrubatın ana maddesini teşkil eder. Şekerli, aromalı veya sitrik asit (asitliği düzenleyici) ihtiva eden soda türleri gazoz olarak adlandırılır.",
                        Category = Categories["Alkolsüz"],
                        ImageUrl = "https://circirselalesi.com.tr/wp-content/uploads/2021/09/soda.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://circirselalesi.com.tr/wp-content/uploads/2021/09/soda.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alkollü", Description="Alkollü İçecekler" },
                        new Category { CategoryName = "Alkolsüz", Description="Alkolsüz İçecekler" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
