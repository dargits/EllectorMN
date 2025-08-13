# ElectorApp - Hệ thống quản lý bình chọn

## 📋 Tổng quan dự án

ElectorApp là một ứng dụng Windows Forms được phát triển bằng C# cho phép tạo và quản lý các cuộc bình chọn trực tuyến. Ứng dụng hỗ trợ hai loại người dùng: **Quản trị viên** có thể tạo các chủ đề bình chọn và **Người dùng thông thường** có thể tham gia bình chọn.

## ✨ Tính năng chính

### 👤 Dành cho người dùng
- Đăng ký và đăng nhập tài khoản
- Xem danh sách các cuộc bình chọn đang diễn ra  
- Tham gia bình chọn với các lựa chọn có sẵn
- Xem kết quả bình chọn trực quan

### 🔧 Dành cho quản trị viên
- Tạo chủ đề bình chọn mới với nhiều lựa chọn
- Quản lý trạng thái hoạt động của các cuộc bình chọn
- Xem báo cáo kết quả chi tiết
- Quản lý người dùng trong hệ thống

### 🔐 Bảo mật
- Phân quyền truy cập rõ ràng
- Quản lý phiên đăng nhập an toàn
- Xác thực người dùng đáng tin cậy

## 🛠️ Công nghệ sử dụng

- **Ngôn ngữ**: C# (.NET Framework)
- **Giao diện**: Windows Forms (WinForm)
- **Cơ sở dữ liệu**: SQL Server
- **IDE**: Visual Studio
- **Kiến trúc**: 2-tier Architecture (Presentation + Service Layer)

## 📁 Cấu trúc dự án

```
ElectorApp/
│
├── App.config                   # Cấu hình ứng dụng và chuỗi kết nối
├── ElectorApp.csproj           # File dự án Visual Studio
│
├── Forms/                      # Lớp giao diện người dùng
│   ├── AdminForms/            # Form dành cho quản trị viên
│   │   ├── AdminDashboard.cs  # Bảng điều khiển admin
│   │   ├── CreatePoll.cs      # Tạo cuộc bình chọn
│   │   └── PollResult.cs      # Xem kết quả bình chọn
│   ├── UserForms/             # Form dành cho người dùng
│   │   ├── UserDashboard.cs   # Bảng điều khiển người dùng
│   │   └── Vote.cs            # Form bình chọn
│   ├── Login.cs               # Màn hình đăng nhập
│   └── Register.cs            # Màn hình đăng ký
│
├── Services/                   # Lớp xử lý nghiệp vụ
│   ├── UserService.cs         # Quản lý người dùng
│   ├── PollService.cs         # Quản lý bình chọn
│   └── VoteService.cs         # Xử lý lượt bình chọn
│
├── Models/                     # Các lớp mô hình dữ liệu
│   ├── User.cs                # Model người dùng
│   ├── Poll.cs                # Model cuộc bình chọn
│   ├── Option.cs              # Model lựa chọn
│   └── Vote.cs                # Model lượt bình chọn
│
└── Utils/                      # Các lớp tiện ích
    └── SessionManager.cs       # Quản lý phiên đăng nhập
```

## 💾 Thiết kế cơ sở dữ liệu

### Bảng Users
Lưu trữ thông tin người dùng và phân quyền

| Cột | Kiểu dữ liệu | Mô tả |
|-----|-------------|--------|
| ID | INT (PK, Identity) | ID duy nhất của người dùng |
| Username | NVARCHAR(50) | Tên đăng nhập (unique) |
| Password | NVARCHAR(255) | Mật khẩu |
| IsAdmin | BIT | Quyền quản trị (1=Admin, 0=User) |
| FullName | NVARCHAR(100) | Họ tên đầy đủ |
| CreatedAt | DATETIME | Thời gian tạo tài khoản |

### Bảng Polls
Lưu trữ các chủ đề bình chọn

| Cột | Kiểu dữ liệu | Mô tả |
|-----|-------------|--------|
| ID | INT (PK, Identity) | ID duy nhất của cuộc bình chọn |
| Title | NVARCHAR(255) | Tiêu đề cuộc bình chọn |
| Description | NVARCHAR(MAX) | Mô tả chi tiết |
| CreatedAt | DATETIME | Thời gian tạo |
| IsActive | BIT | Trạng thái hoạt động |
| UserID | INT | ID người tạo |

### Bảng Options
Lưu trữ các lựa chọn của từng cuộc bình chọn

| Cột | Kiểu dữ liệu | Mô tả |
|-----|-------------|--------|
| ID | INT (PK, Identity) | ID duy nhất của lựa chọn |
| PollID | INT (FK) | Liên kết đến cuộc bình chọn |
| OptionText | NVARCHAR(255) | Nội dung lựa chọn |
| ImageUrl | NVARCHAR(255) | Link ảnh |

### Bảng Votes
Lưu trữ các lượt bình chọn

| Cột | Kiểu dữ liệu | Mô tả |
|-----|-------------|--------|
| ID | INT (PK, Identity) | ID duy nhất của lượt vote |
| PollID | INT (FK) | Liên kết đến cuộc bình chọn |
| OptionID | INT (FK) | Liên kết đến lựa chọn |
| UserID | INT (FK) | Liên kết đến người dùng |
| VotedAt | DATETIME | Thời gian bình chọn |

## 🚀 Cài đặt và chạy dự án

### Yêu cầu hệ thống
- Windows 10/11
- Visual Studio 2019 trở lên
- SQL Server 2016 trở lên
- .NET Framework 4.7.2 trở lên

### Các bước cài đặt

1. **Clone dự án**
   ```bash
   git clone https://github.com/yourname/ElectorApp.git
   cd ElectorApp
   ```

2. **Tạo cơ sở dữ liệu**
   - Mở SQL Server Management Studio
   - Tạo database mới có tên `ElectorDB`
   - Chạy script SQL để tạo các bảng:

   ```sql
   -- Tạo bảng Users
   CREATE TABLE Users (
       ID INT PRIMARY KEY IDENTITY(1,1),
       Username NVARCHAR(50) NOT NULL UNIQUE,
       Password NVARCHAR(255) NOT NULL,
       IsAdmin BIT DEFAULT 0,
       FullName NVARCHAR(100) NULL,
       CreatedAt DATETIME DEFAULT GETDATE()
   );

   -- Tạo bảng Polls
   CREATE TABLE Polls (
       ID INT PRIMARY KEY IDENTITY(1,1),
       Title NVARCHAR(255) NOT NULL,
       Description NVARCHAR(MAX) NULL,
       CreatedAt DATETIME DEFAULT GETDATE(),
       IsActive BIT DEFAULT 1
   );

   -- Tạo bảng Options
   CREATE TABLE Options (
       ID INT PRIMARY KEY IDENTITY(1,1),
       PollID INT NOT NULL,
       OptionText NVARCHAR(255) NOT NULL,
       FOREIGN KEY (PollID) REFERENCES Polls(ID)
   );

   -- Tạo bảng Votes
   CREATE TABLE Votes (
       ID INT PRIMARY KEY IDENTITY(1,1),
       PollID INT NOT NULL,
       OptionID INT NOT NULL,
       UserID INT NOT NULL,
       VotedAt DATETIME DEFAULT GETDATE(),
       FOREIGN KEY (PollID) REFERENCES Polls(ID),
       FOREIGN KEY (OptionID) REFERENCES Options(ID),
       FOREIGN KEY (UserID) REFERENCES Users(ID)
   );
   ```

3. **Cấu hình kết nối**
   - Mở file `App.config`
   - Cập nhật connection string cho phù hợp:

   ```xml
   <connectionStrings>
     <add name="MyDbConnection" 
          connectionString="Server=your_server;Database=ElectorDB;Integrated Security=true;" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. **Build và chạy**
   - Mở dự án trong Visual Studio
   - Build solution (Ctrl + Shift + B)
   - Chạy ứng dụng (F5)

## 📝 Hướng dẫn sử dụng

### Đối với người dùng mới
1. Chạy ứng dụng và chọn "Đăng ký" 
2. Nhập thông tin tài khoản và tạo tài khoản mới
3. Đăng nhập bằng tài khoản vừa tạo
4. Xem danh sách các cuộc bình chọn và tham gia

### Đối với quản trị viên
1. Tạo tài khoản admin đầu tiên bằng cách update trực tiếp trong database:
   ```sql
   UPDATE Users SET IsAdmin = 1 WHERE Username = 'your_admin_username';
   ```
2. Đăng nhập với tài khoản admin
3. Tạo các chủ đề bình chọn mới
4. Quản lý và xem kết quả các cuộc bình chọn

## 🔧 API Services chính

### UserService
- `RegisterUser()` - Đăng ký người dùng mới
- `ValidateLogin()` - Xác thực đăng nhập
- `CheckUsernameExists()` - Kiểm tra tên đăng nhập tồn tại

### PollService  
- `CreatePoll()` - Tạo cuộc bình chọn mới
- `GetActivePolls()` - Lấy danh sách bình chọn đang hoạt động
- `GetPollDetails()` - Lấy chi tiết một cuộc bình chọn
- `GetPollResults()` - Lấy kết quả bình chọn

### VoteService
- `SubmitVote()` - Ghi nhận lượt bình chọn
- `HasUserVoted()` - Kiểm tra người dùng đã vote chưa

## 🤝 Đóng góp

Chúng tôi hoan nghênh mọi đóng góp cho dự án! Vui lòng:

1. Fork dự án
2. Tạo feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to branch (`git push origin feature/AmazingFeature`)
5. Mở Pull Request

## 📄 Giấy phép

Dự án này được phát hành dưới giấy phép MIT. Xem file `LICENSE` để biết thêm chi tiết.

## 📞 Liên hệ

- **Tác giả**: [Bàn Hữu Sự x Hoàng Quý Ngọc x Ngô Văn Sâm]
- **Email**: [imshydev@gmail.com]
- **GitHub**: [https://github.com/dargits]

---

⭐ **Nếu dự án hữu ích, hãy để lại một star trên GitHub!** ⭐



