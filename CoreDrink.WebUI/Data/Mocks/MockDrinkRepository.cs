using CoreDrink.WebUI.Data.Interfaces;
using CoreDrink.WebUI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDrink.WebUI.Data.Mocks
{
    public class MockDrinkRepository : IDrinkRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Drink> Drinks 
        {
            get
            {
                return new List<Drink>
                {
                    new Drink
                    {
                        Name = "Bira",
                        Price = 140.75M,
                        ShortDescription = "En çok tüketilen alkol",
                        LongDescription = "Bira dünyanın en eski ve en yaygın tüketilen alkollü içeceğidir; su ve çaydan sonra genel olarak en popüler üçüncü içecektir.Bira üretimi, buğday, mısır (mısır) ve pirinç yaygın olarak kullanılmasına rağmen, çoğunlukla malt arpa gibi tahıl tanelerinden elde edilen nişastaların fermantasyonunu içeren biracılık olarak adlandırılır. [6] Çoğu bira, acılık katan ve doğal bir koruyucu görevi gören şerbetçiotu ile tatlandırılır, ancak bazen otlar veya meyveler gibi diğer tatlandırıcılar da dahil edilebilir. Fermantasyon süreci doğal bir karbonatlaşma etkisine neden olur, ancak bu genellikle işleme sırasında çıkarılır ve yerine zorunlu karbonatlaşma uygulanır.[7] İnsanlığın bilinen en eski yazılarından bazıları bira üretimi ve dağıtımına atıfta bulunur: Hammurabi Kanunları bira ve birahaneleri düzenleyen yasalar içeriyordu.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://www.hukins-hops.co.uk/wp-content/uploads/2024/04/what-is-the-percentage-alcohol-in-beer.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://hips.hearstapps.com/del.h-cdn.co/assets/cm/15/11/3200x3272/54f65d39ab05d_-_183341797.jpg?resize=640:*"
                    },
                    new Drink
                    {
                        Name = "Rom ve Kola",
                        Price = 105.95M,
                        ShortDescription = "Kola, misket limonu ve romdan yapılan kokteyl.",
                        LongDescription = "Dünyanın en popüler ikinci içkisi Amerika Birleşik Devletleri ve İspanya arasındaki bir çarpışmada doğdu. Olay, yüzyılın başında İspanya-Amerika Savaşı sırasında Teddy Roosevelt, Rough Riders ve çok sayıda Amerikalı Küba'ya geldiğinde meydana geldi. Bir öğleden sonra, ABD Muhabere Birliği'nden bir grup izinli asker Eski Havana'da bir barda toplanır. Genç bir haberci olan Fausto Rodriguez daha sonra Yüzbaşı Russell'ın içeri girdiğini ve Bacardi (Gold) romu ile buzlu Coca-Cola ve bir dilim limon sipariş ettiğini hatırladı. Yüzbaşı bu karışımı öylesine keyifle içmiş ki, etrafındaki askerlerin de ilgisini çekmiş. Barmene kendileri için yüzbaşının içkisinden bir tur hazırlattılar. Bacardi romu ve kola anında hit oldu. Bugün de olduğu gibi, bu içki kalabalığı eğlence ve dostluk ruhu içinde birleştirdi. Bir tur daha sipariş ettiklerinde, bir asker yeni özgürlüğüne kavuşan Küba'yı kutlamak için ¡Por Cuba Libre! şerefine kadeh kaldırmalarını önerdi.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://media.diageocms.com/eyJrZXkiOiJtZWRpYS9tNHNua2Z4eS9iYXJjb21fc2VydmVfaW1hZ2VfMTU0MDc2MF9jYXB0YWlubW9yZ2FucnVtY29sYS5qcGciLCJlZGl0cyI6eyJyZXNpemUiOnsiaGVpZ2h0Ijo2MTAsIndpZHRoIjo2MTB9fX0=",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://blog-assets.lightspeedhq.com/img/2021/11/a488ea02-36_bartenders-share-secrets-ultimate-rum-coke_01-hero.jpg"
                    },
                    new Drink
                    {
                        Name = "Tekila",
                        Price = 89.95M,
                        ShortDescription = "Mavi agave bitkisinden yapılan içecek.",
                        LongDescription = "Tekila (İspanyolca Bu ses hakkında [teˈkila] (help-info)), öncelikle Guadalajara'nın 65 km (40 mil) kuzeybatısındaki Tequila şehrini çevreleyen alanda ve orta batı Meksika eyaleti Jalisco'nun dağlık bölgelerinde (Los Altos) mavi agave bitkisinden yapılan damıtılmış bir içeceğin bölgesel olarak özel bir adıdır. Tekila mezkalaya benzemekle birlikte, modern tekila üretim yöntemi, sadece mavi agave bitkilerinin kullanılması ve bölgesel özgünlüğü bakımından biraz farklılık gösterir. Tekila Meksika'da genellikle sek olarak, dünyanın geri kalanında ise tuz ve misket limonu ile shot olarak servis edilir. Çevredeki kırmızı volkanik toprak mavi agav yetiştirmek için özellikle uygundur ve her yıl 300 milyondan fazla bitki hasat edilmektedir. Los Altos dağlık bölgesinde yetişen mavi agavların boyutları daha büyük, aroma ve tatları daha tatlıdır. Ovalarda hasat edilen agavlar ise daha otsu bir koku ve tada sahiptir.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://www.gurmerehberi.com/wp-content/uploads/2021/10/Bir-Tequila-Sour-kokteyli-klasik-ve-zarif-bir-sunumla.-Kokteyl-5-cl-tequila-3-cl-taze-sikilmis-limon-suyu-ve-15-cl-seker-surubu-karisimindan-olusu.png",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://wevino.store/cdn/shop/products/2052-Tequila-Jose-Cuervo-Especial-Gold-Reposado_170a059b-a9fd-44ff-85fc-e4ba6d5bb575.jpg?v=1710711151"
                    },
                    new Drink
                    {
                        Name = "Meyve Suyu",
                        Price = 52.75M,
                        ShortDescription = "Meyve veya sebze dokusunda doğal olarak bulunur.",
                        LongDescription = "Meyve suyu, meyve ve sebzelerde bulunan doğal sıvının ekstraksiyonundan veya preslenmesinden elde edilen bir içecektir. Aynı zamanda konsantre veya istiridye suyu gibi et veya deniz ürünleri gibi diğer biyolojik gıda kaynakları ile tatlandırılmış sıvıları da ifade edebilir. Meyve suyu genellikle bir içecek olarak tüketilir veya gıdalarda ya da smoothie gibi diğer içeceklerde bir bileşen veya tatlandırıcı olarak kullanılır. Meyve suyu, pastörizasyon yöntemlerinin geliştirilmesinden sonra fermantasyon (şarap üretiminde kullanılan) kullanılmadan muhafaza edilmesini sağlayan popüler bir içecek seçeneği olarak ortaya çıkmıştır. En büyük meyve suyu tüketicileri Yeni Zelanda (her gün yaklaşık bir fincan veya 8 ons) ve Kolombiya'dır (her gün bir fincanın dörtte üçünden fazlası). Meyve suyu tüketimi ortalama olarak bir ülkenin gelir seviyesiyle birlikte artmaktadır.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://fruitjuicesciencecentre.eu//storage/files/269fa21f-e822-44c0-ae21-fecbebb22cf3/header_green_small_5-reasons.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://product.hstatic.net/200000325223/product/8-08_8bdce2f395364fa9a1ef7b3f2e0fb571_master.png"
                    }
                };
            }
            set
            {
                throw new NotImplementedException();
            }
        }
                
        public IEnumerable<Drink> PreferredDrinks { get; set; }

        public Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}
