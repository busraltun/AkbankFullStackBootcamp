# BusraAltun_HtmlTemplate
* index.js dosyasını oluşturduk çünkü bu dosya React ın çalışmaya başladığı dosyadır.
#
## Component

* Bir fonksiyon yahut bir class(sınıf) tan oluşan JavaScript kodudur.
* Fonksiyon component ve class component olacak şekilde 2 kısımda incelemek mümkündür.
* Componentler bir nevi fonksiyon gibi çalışır. Parametre gönderilebilir (bunları props diye adlandırıyoruz), yapacağı spesifik işlemi yapar ve ekranda neler görüneceğini açıklayan React elementleri return ile döndürürler.
* Component için ; "Sitenizi büyük bir puzzle olarak düşünün. React ile önce teker teker puzzle parçalarını oluşturup ardından bunları birleştirerek büyük resmi oluşturacaksınız" şeklinde de söylenilmektedir.

#### Element : Component'ın en küçük yapı taşıdır.
#
## Functional Component
* Fonksiyonel Component lar temel olarak React elementlerini (JSX) dönen JavaScript fonksiyonlarıdır.
* v.16.8 ile beraber fonksiyonel componentlar state' e erişim sağlayabilir oldu.
#### Örnek Functional Component 
![lokk the png](/images/5.PNG)
Mesela bu çok basit ve temel bir componenttır ek olarak da bu bir fonksiyonel componenttır deriz.
* Ayrıca arrow functıon olarak da bunu daha sade bir şekilde gösterebiliyoruz. Bknz.
![lokk the png](/images/8.PNG)
* Bu oluşan component ı sayfamızda görünmesini sağlamak için component ımızı render etmemiz lazım. **render() metodu ReactDom' a ait bir metottur.**

![lokk the png](/images/6.PNG)
#
## Class Component (ES6)
* React kütüphanesi içerisindeki “Component” class ‘ından extend olan javascript class ‘ları şeklinde tanımlayabiliriz. (React.Component)
*  Bu class ‘lar React Component ‘ten extend olduğu için Component Lifecycle süreçlerini de barındırır
* Bir React bileşeni oluştururken bileşenin adı büyük harfle başlamalıdır.

* Bileşenin extends React.Componentifadeyi içermesi gerekir. 
* Bu ifade React.Component için bir miras oluşturur ve bileşeninize 
React.Component'in işlevlerine erişim sağlar.
* Bileşen ayrıca bir render()yöntem gerektirir , bu yöntem HTML döndürür.
![lokk the png](/images/7.PNG)
#
## Props ve State Kavramları Özet
* Prop -> Parameter. Component ‘e geçilen parametre diyebiliriz. React, component ları kullanan bir kütüphane ve React' ın temel işlevi bu component ları sayfada uygun yerlere yerleştirmektir. Bazı durumlarda bu componentlar arasında veri alışverişi olur. İşte bu alışverişi React'ta props lar yardımıyla gerçekleştirilir. 
* Yani React'ın props özelliği bize React'ın en temel birimleri olan componentlar arasındaki veri iletişimini, veri akışını sağlar. Bu veri iletişimi ise parent component tan child component'ına doğru gerçekleşir. Veri diye bahsettiğimiz şeyi özellikler olarak düşünebiliriz. Ve bu özellikler tek yönlü olur. Yani bu özellikleri parent component ta belirleriz ( index.js). Child component vasıtasıyla gösteririz. (personalcard.js). Dolayısıyla yön parenttan child a doğrudur.
* State -> Component Memory. Component oluşturulduğunda içinde veri tutacak olan javascript nesnesi/objesi.
#
#
* Kod içerisinde tekrar eden noktaları ayrı bir component şeklinde oluşturmak React uygulamasını daha modüler bir hale getirmemizi sağlar. Böylelikle yarın öbür gün dilediğimiz gibi taşıma, değiştirme işlemlerini gerçekleştirebiliriz.