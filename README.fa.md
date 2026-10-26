<div dir="rtl">

# 🎓 OstadWeb

> یک پروژه‌ی عملی **ASP.NET Web Forms** که گام‌به‌گام در کلاس ساخته شده و یک فروشگاه اینترنتی کوچک، بستر تمرین آن است.

</div>

![ASP.NET](https://img.shields.io/badge/ASP.NET-Web%20Forms-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-.NET%204.5.2-239120?logo=csharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-CC2927?logo=microsoftsqlserver&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?logo=bootstrap&logoColor=white)

---

<div dir="rtl">

## 👨‍🏫 قدردانی و اعتبار

این مخزن و تمام مطالب اصلی آن متعلق به **دکتر فرقانی**
([@Shahabforghani](https://github.com/Shahabforghani))، استاد ما در دانشگاه است.

📝 ما فقط پس از هر جلسه تغییرات کوچکی روی فایل‌ها اعمال می‌کنیم تا کد با کلاس هم‌گام بماند
و هر کسی که یک یادداشت یا عکس تخته را از دست داده است بتواند عقب‌ماندگی‌اش را جبران کند.

---

## ✨ محتوای پروژه

یک فروشگاه کوچک که در آن می‌توانید محصولات را فهرست کنید، جستجو کنید، محصول جدید همراه با تصویر اضافه کنید و جزئیات آن‌ها را ببینید.

| صفحه | کارکرد |
| --- | --- |
| `Default.aspx` | صفحه‌ی اصلی (از Master Page استفاده می‌کند) |
| `List.aspx` | کارت‌های محصول همراه با نوار کناری فیلتر (راست‌چین، Bootstrap) |
| `Product_list.aspx` | دمو: ارسال یک شناسه (ID) با **QueryString** در مقایسه با **Session** |
| `Product_dtl.aspx` | صفحه‌ی جزئیات محصول؛ شناسه‌ی دریافت‌شده را نمایش می‌دهد |
| `search_frm.aspx` | جستجو بر اساس نام یا شناسه، با نمایش نتایج در GridView |
| `Item_mng.aspx` | افزودن یک کالا (نام + قیمت) |
| `Upload_form.aspx` | افزودن کالا همراه با **آپلود تصویر** |
| `AdminPanel/` | بخش مدیریت خالی، آماده برای جلسات بعدی |

---

## 🗂️ ساختار پروژه

<div dir="ltr">

```
MyWeb/
├── AdminPanel/      → صفحات مدیریت (فعلاً خالی)
├── assets/css/      → Bootstrap 5.3.8
├── CLS/             → لایه‌ی داده (connection.cs, item.cs)
├── upload/          → تصاویر آپلودشده‌ی محصولات
├── MS1.Master       → چیدمان مشترک (منو، محتوا، فوتر)
├── *.aspx / *.cs    → صفحات و کد پشت آن‌ها (code-behind)
└── Web.config       → تنظیمات سایت
```

</div>

---

## 🚀 شروع کار

1. **Visual Studio** را به همراه workload با نام *ASP.NET and web development* نصب کنید.
2. **SQL Server** (نسخه‌ی Express یا LocalDB کافی است) را روی سیستم خود نصب کنید.
3. یک پایگاه داده با نام **`shop`** و در آن جدولی با نام **`item_tbl`** بسازید. مثال:

<div dir="ltr">

   ```sql
   CREATE TABLE item_tbl (
       ItemID  INT IDENTITY(1,1) PRIMARY KEY,
       ItmName NVARCHAR(100),
       Iprice  INT,
       Iimg    NVARCHAR(250)
   );
   ```

</div>

4. فایل `MyWeb.sln` را باز کنید، بسته‌های NuGet را restore کنید و کلید **F5** را بزنید تا پروژه اجرا شود.

> رشته‌ی اتصال (connection string) در فایل `CLS/connection.cs` قرار دارد و از `Data Source=.` همراه با احراز هویت ویندوز استفاده می‌کند.
> اگر نمونه‌ی SQL Server شما نام دیگری دارد، آن را همان‌جا تغییر دهید.

---

## 📚 موضوعات پوشش‌داده‌شده تاکنون

- 🧱 Master Page‌ها و Content Placeholder‌ها
- 🔗 انتقال داده بین صفحات: QueryString، Session و `Server.Transfer`
- 🗃️ اتصال به SQL Server با `SqlConnection` و `SqlDataAdapter`
- 🧾 کنترل‌های داده‌محور: `ListView` و `GridView`
- 📤 آپلود فایل با `FileUpload`
- 🎨 کارت‌ها، گرید و دکمه‌های Bootstrap

---

## 🛠️ نکات

- بخشی از کوئری‌های SQL عمداً و برای اهداف آموزشی از ورودی کاربر ساخته شده‌اند. **آن‌ها را به همین شکل در یک پروژه‌ی واقعی استفاده نکنید**؛
  ابتدا آن‌ها را به کوئری‌های پارامتری (`SqlParameter`) تبدیل کنید.
- این پروژه یک محیط تمرین و یادگیری است و جلسه‌به‌جلسه گسترش خواهد یافت. 🌱

---

<p align="center">ساخته‌شده برای یادگیری 💜 &nbsp;|&nbsp; اثر اصلی از دکتر فرقانی &nbsp;|&nbsp; یادداشت‌ها از دانشجویان مهندسی کامپیوتر 🤍</p>

</div>

---

<p align="center">
  <a href="README.md">
    <img src="https://img.shields.io/badge/Read%20in-English-512BD4?style=for-the-badge" alt="Read in English">
  </a>
</p>

<p align="center" dir="rtl">📖 برای مطالعه‌ی این فایل به زبان انگلیسی، روی دکمه‌ی بالا کلیک کنید.</p>
