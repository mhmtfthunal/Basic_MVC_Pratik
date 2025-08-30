# Basic MVC Pratik

ASP.NET Core MVC ile **Müşteri & Sipariş Bilgilerini Görüntüleme** pratiği. Bu proje; `Customer`, `Order` modelleri; bunları birleştiren `CustomerOrderViewModel`; veriyi hazırlayan `CustomerOrdersController` ve Bootstrap 5 ile sade bir arayüzden oluşur.

> **Hızlı bakış:** `GET /CustomerOrders/Index` açıldığında örnek müşteri bilgileri ve sipariş tablosu listelenir.

---

## 🎯 Amaç

* MVC katmanlarını doğru konumlandırmak (Model / ViewModel / Controller / View)
* Basit veri modelini ViewModel ile view’a taşımak
* Bootstrap 5 ile hızlı, sade bir görünüm sağlamak

---

## 🧰 Teknolojiler

* **.NET SDK:** 8.0
* **Framework:** ASP.NET Core MVC
* **UI:** Bootstrap 5 (CDN)

> .NET sürümünüzü kontrol edin: `dotnet --version`

---

## 🚀 Kurulum & Çalıştırma

```bash
# Projeyi klonla
git clone https://github.com/mhmtfthunal/Basic_MVC_Pratik.git
cd Basic_MVC_Pratik/Basic_MVC_Pratik

# Çalıştır
dotnet run
# tarayıcıda aç
# https://localhost:xxxx/  veya  /CustomerOrders/Index
```

> Proje Visual Studio ile açıldığında `Basic_MVC_Pratik.sln` üzerinden build/run da yapabilirsiniz.

---

## 📂 Klasör Yapısı

```
Basic_MVC_Pratik/
├─ Controllers/
│  └─ CustomerOrdersController.cs
├─ Models/
│  ├─ Customer.cs
│  └─ Order.cs
├─ ViewModels/
│  └─ CustomerOrderViewModel.cs
├─ Views/
│  ├─ CustomerOrders/
│  │  └─ Index.cshtml
│  ├─ Shared/
│  │  └─ _Layout.cshtml
│  ├─ _ViewImports.cshtml
│  └─ _ViewStart.cshtml
├─ wwwroot/
│  └─ css/
│     └─ site.css
├─ appsettings.json
├─ Program.cs
└─ Basic_MVC_Pratik.csproj
```

---

## 🧱 Modeller ve ViewModel

### `Models/Customer.cs`

* `Id`, `FirstName`, `LastName`, `Email`
* `FullName` (hesaplanan özellik)

### `Models/Order.cs`

* `Id`, `ProductName`, `Price (decimal)`, `Quantity (int)`
* `LineTotal` = `Price * Quantity`

### `ViewModels/CustomerOrderViewModel.cs`

* `Customer` (Customer)
* `Orders` (List<Order>)
* `GrandTotal` (siparişlerin toplamı)

---

## 🎮 Controller

### `Controllers/CustomerOrdersController.cs`

* **Index()**: Örnek `Customer` ve `List<Order>` oluşturur, `CustomerOrderViewModel` ile `Index.cshtml`’e gönderir.

---

## 🖼️ Görünüm (View)

### `Views/CustomerOrders/Index.cshtml`

* Müşteri bilgilerini kart içinde gösterir
* Siparişleri responsive tablodan listeler
* `@model CustomerOrderViewModel`

### Layout & Bootstrap

* `Views/Shared/_Layout.cshtml` içinde **Bootstrap 5 (CDN)** yüklüdür
* `Views/_ViewStart.cshtml` içinde `Layout = "_Layout";` tanımlanır

---

## 🔗 Rotalar

* Varsayılan rota: `CustomerOrders/Index`

  ```csharp
  // Program.cs
  app.MapControllerRoute(
      name: "default",
      pattern: "{controller=CustomerOrders}/{action=Index}/{id?}");
  ```

---

## 🧩 Pratik Aşamaları (Ödev eşlemesi)

1. **Model**: `Customer`, `Order`
2. **ViewModel**: `CustomerOrderViewModel (Customer + List<Order>)`
3. **Controller**: `CustomerOrdersController.Index()` içinde örnek veri hazırlanır
4. **View**: `Index.cshtml` müşteriyi ve sipariş tablosunu Bootstrap ile gösterir

---

## 🧪 Hızlı Kontrol Listesi

* [ ] `@model CustomerOrderViewModel` doğru mu?
* [ ] `_Layout.cshtml` **/Views/Shared** altında mı?
* [ ] `Views/_ViewStart.cshtml` var mı ve `Layout = "_Layout"` diyor mu?
* [ ] `using ...ViewModels;` ve `using ...Models;` eksiksiz mi?

---

## 🛠️ Sık Karşılaşılan Hatalar

### 1) `CS0234` (namespace bulunamadı)

* View’da `@model` satırında yanlış namespace/ad kullanılmış olabilir.
* Doğrusu: `@model CustomerOrderViewModel` (eğer `_ViewImports.cshtml`’de `@using ...ViewModels` varsa) ya da tam ad: `@model Basic_MVC_Pratik.ViewModels.CustomerOrderViewModel`.

### 2) `The layout view "_Layout" could not be located`

* `_Layout.cshtml` yanlış klasörde. **Doğru yer:** `/Views/Shared/_Layout.cshtml` (veya view klasörünüzde).
* `Views/_ViewStart.cshtml` dosyasını ekleyin: `Layout = "_Layout";`

---

## 🧭 Geliştirme İpuçları

* Bootstrap’ı CDN yerine yerel kullanmak isterseniz `_Layout.cshtml`’de CDN linklerini lib yoluyla değiştirin.
* Demo verileri `CustomerOrdersController` içinde — gerçek veri bağlamak için burayı servis/DB ile değiştirin.

