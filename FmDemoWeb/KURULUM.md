# 🚀 Dosya Yöneticisi - Kurulum Kılavuzu

## ✅ Proje Yapısı Hazır!

Modern ASP.NET Core projelerinde (6.0+) **`Startup.cs`** artık kullanılmıyor. 
Bunun yerine **`Program.cs`** dosyasında minimal hosting model kullanılıyor.

## 📁 Proje Dosya Yapısı

```
FmDemoWeb/
├── Controllers/
│   ├── DemoController.cs              ✅ Ana sayfa controller
│   └── FileManagerController.cs       ✅ Dosya işlemleri controller
├── Services/
│   ├── IFileManager.cs                ✅ Interface
│   └── FileManager.cs                 ✅ Servis implementasyonu
├── Views/
│   ├── Shared/
│   │   ├── _Layout.cshtml             ✅ Layout dosyası
│   │   └── _FileManagerPartial.cshtml ✅ Dosya yöneticisi UI
│   ├── Demo/
│   │   └── Index.cshtml               ✅ Ana sayfa
│   ├── _ViewStart.cshtml              ✅ View başlangıç
│   └── _ViewImports.cshtml            ✅ View importları
├── Properties/
│   └── launchSettings.json            ✅ Debug ayarları
├── wwwroot/
│   └── uploads/                       ✅ Yüklenen dosyalar
├── Program.cs                         ✅ Ana giriş noktası (Startup yerine!)
├── FmDemoWeb.csproj                   ✅ Proje dosyası
├── appsettings.json                   ✅ Uygulama ayarları
├── appsettings.Development.json       ✅ Development ayarları
├── README.md                          ✅ Detaylı döküman
└── KURULUM.md                         ✅ Bu dosya
```

## 📝 Program.cs Açıklaması

Modern ASP.NET Core'da **tüm konfigürasyon `Program.cs` içinde** yapılır:

```csharp
using FmDemoWeb.Services;

var builder = WebApplication.CreateBuilder(args);

// ✅ 1. MVC servislerini ekle
builder.Services.AddControllersWithViews();

// ✅ 2. FileManager servisini Dependency Injection'a kaydet
builder.Services.AddSingleton<IFileManager>(provider =>
{
    var uploadsPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
    return new FileManager(uploadsPath);
});

var app = builder.Build();

// ✅ 3. Middleware pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // ÖNEMLİ: wwwroot klasörü için!

app.UseRouting();
app.UseAuthorization();

// ✅ 4. Default route ayarı (Demo/Index)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Demo}/{action=Index}/{id?}");

app.Run();
```

## 🔧 Kurulum Adımları

### 1. Proje Restore
```bash
cd /workspace/FmDemoWeb
dotnet restore
```

### 2. Paket Kontrolü
```bash
# ImageSharp paketi zaten .csproj dosyasında tanımlı
# Otomatik olarak yüklenecek
```

### 3. Projeyi Çalıştırma
```bash
dotnet run
```

### 4. Tarayıcıda Açma
```
http://localhost:5000
```

## 🎯 Önemli Noktalar

### ✅ Startup.cs YOK!
Modern ASP.NET Core 6.0+ projelerinde `Startup.cs` dosyası kaldırıldı.
Tüm konfigürasyon `Program.cs` içinde yapılıyor.

### ✅ Minimal Hosting Model
```csharp
// ESKİ Yöntem (ASP.NET Core 5.0 ve öncesi)
public class Startup
{
    public void ConfigureServices(IServiceCollection services) { }
    public void Configure(IApplicationBuilder app) { }
}

// YENİ Yöntem (ASP.NET Core 6.0+)
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSomething();
var app = builder.Build();
app.UseSomething();
app.Run();
```

### ✅ Dependency Injection
FileManager servisi `Program.cs` içinde kaydedildi:
```csharp
builder.Services.AddSingleton<IFileManager>(provider =>
{
    var uploadsPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
    return new FileManager(uploadsPath);
});
```

### ✅ Static Files Middleware
`UseStaticFiles()` çağrısı sayesinde `wwwroot` klasöründeki dosyalar sunuluyor:
```csharp
app.UseStaticFiles();
```

## 🧪 Test Etme

1. Projeyi çalıştırın: `dotnet run`
2. Tarayıcıda açın: `http://localhost:5000`
3. "Dosya Yöneticisini Aç" butonuna tıklayın
4. Özellikler:
   - ✅ Klasör oluşturma (alt klasör desteği)
   - ✅ Dosya yükleme (drag & drop)
   - ✅ Görsel düzenleme (kırpma, boyutlandırma)
   - ✅ Görsel görüntüleme (gerçek boyut)
   - ✅ Loading ekranı (1 saniye minimum)
   - ✅ Success dialog
   - ✅ Smooth folder selection

## 🐛 Sorun Giderme

### Proje başlamıyor
```bash
# Port kullanımda olabilir, farklı port deneyin:
dotnet run --urls="http://localhost:5050"
```

### Görseller görünmüyor
```bash
# wwwroot/uploads klasörünün olduğundan emin olun:
ls -la wwwroot/uploads
```

### Paket hatası
```bash
# Paketleri yeniden yükleyin:
dotnet clean
dotnet restore
dotnet build
```

## 📚 Ek Bilgiler

### Proje Versiyonu
- **Framework:** .NET 8.0
- **ImageSharp:** 3.1.5
- **Pattern:** MVC

### Port Bilgileri
- **HTTP:** http://localhost:5000
- **HTTPS:** https://localhost:5001

### Klasör İzinleri
```bash
# Linux/Mac için uploads klasörüne yazma izni:
chmod 755 wwwroot/uploads
```

## 🎓 Öğrenme Notları

### Neden Startup.cs Yok?
Microsoft, ASP.NET Core 6.0 ile birlikte kodu daha basit ve okunabilir hale getirmek için:
- `Startup.cs` dosyasını kaldırdı
- `Program.cs` içinde minimal hosting model kullanıyor
- Daha az boilerplate kod
- Daha hızlı başlangıç

### Avantajları
- ✅ Tek dosyada tüm konfigürasyon
- ✅ Daha az kod
- ✅ Daha anlaşılır
- ✅ Top-level statements

### Eskiden Nasıldı?
```csharp
// Program.cs (ESKİ)
public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }
    
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}

// Startup.cs (ESKİ)
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
    }
    
    public void Configure(IApplicationBuilder app)
    {
        app.UseRouting();
        app.UseEndpoints(...);
    }
}
```

### Şimdi Nasıl?
```csharp
// Program.cs (YENİ)
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseRouting();
app.MapControllers();
app.Run();
```

Çok daha temiz! 🎉

## 📞 Destek

Herhangi bir sorun yaşarsanız:
1. `dotnet --version` ile .NET versiyonunu kontrol edin
2. Console'da hata mesajlarını okuyun
3. README.md dosyasını inceleyin

**Başarılar!** 🚀
