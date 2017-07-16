# Tài liệu thiết kế
Đây là tài liệu phân tích thiết kế hệ thống trước khi bắt tay và xây dựng phần mềm
## Đặc tả hệ thống
- Hệ thống quản lý sinh viên này chỉ dành cho một lớp người sử dụng (Phòng đào tạo) nên không thực hiện chức năng phân quyền.
- Hệ thống thực hiện các chức năng **Quản lý sinh viên**, **Quản lý điểm**, **Quản lý môn học**, **Quản lý Khoa/Lớp**, **Tìm kiếm** và **Báo cáo - Thống kê**.
- Tất cả những thay đổi tác động qua từng chức năng đều ảnh hưởng đến **Cơ sở dữ liệu**.
## Sơ đồ phân rã chức năng (BFD)
![screenshot 21](https://user-images.githubusercontent.com/27407242/28238962-187324aa-698a-11e7-8274-a469020e8b07.png)
## Sơ đồ luồng dữ liệu (DFD)
![screenshot 22](https://user-images.githubusercontent.com/27407242/28239243-c5798dea-6991-11e7-803e-c6e6dc0fb12e.png)
## Sơ đồ thực thể - quan hệ (ERD)
![erd](https://user-images.githubusercontent.com/27407242/28239269-762657ae-6992-11e7-8aa9-883bbc7041d1.JPG)
## Thiết kế và mô tả mô hình dữ liệu vật lý
### 1) Bảng Giảng viên
| Column Name | Data Type | Allows NULL |
|-------------|-----------|-------------|
| MaGV | nvarchar(10) | NOT NULL |
| TenGV | nvarchar(50) | NULL |
#### Mô tả:
- MaGV: Mã của giảng viên
- TenGV: Tên của giảng viên
### 2) Bảng Học kỳ
| Column Name | Data Type | Allows NULL |
|-------------|-----------|-------------|
| MaHK | nvarchar(10) | NOT NULL |
| TenHK | nvarchar(50)| NULL |
#### Mô tả:
- MaHK: Mã của học kỳ
- TenHK: Tên của học kỳ
### 3) Bảng Môn học
| Column Name | Data Type | Allows NULL |
|-------------|-----------|-------------|
| MaMH | nvarchar(10) | NOT NULL |
| TenMH | nvarchar(50) | NULL |
| MaGV | nvarchar(10) | NOT NULL |
#### Mô tả:
- MaMH: Mã của môn học
- TenMH: Tên của môn học
- MaGV: Mã của giảng viên phụ trách môn học
### 4) Bảng Lớp
| Column Name | Data Type | Allows NULL |
|-------------|-----------|-------------|
| MaLop | nvarchar(10) | NOT NULL |
| TenLop | nvarchar(50) | NULL |
| MaKhoa | nvarchar(10) | NOT NULL |
| MaGV | nvarchar(10) | NOT NULL |
#### Mô tả:
- MaLop: Mã của lớp
- TenLop: Tên của lớp
- MaKhoa: Mã của khoa (Lớp thuộc khoa nào thì chọn mã khoa đó)
- MaGV: Mã của giảng viên phụ trách lớp
### 5) Bảng Khoa
| Column Name | Data Type | Allows NULL |
|-------------|-----------|-------------|
| MaKhoa | nvarchar(10) | NULL |
| TenKhoa | nvarchar(50) | NOT NULL |
#### Mô tả:
- MaKhoa: Mã của khoa
- TenKhoa: Tên của khoa
### 6) Bảng Điểm
| Column Name | Data Type | Allows NULL |
|-------------|-----------|-------------|
| MaSV | nvarchar(10) | NOT NULL |
| MaMH | nvarchar(10) | NOT NULL |
| DiemCC | int | NULL |
| DiemKT | float | NULL |
| DiemGK | float | NULL |
| DiemThi | float | NULL |
| DiemTB | float | NULL |
| MaGV | nvarchar(10) | NOT NULL |
| MaHK | nvarchar(10) | NOT NULL |
#### Mô tả:
- MaSV: Mã sinh viên cần nhập điểm
- MaMH: Mã môn học cần nhập điểm
- DiemCC: Điểm chuyên cần của sinh viên
- DiemKT: Điểm kiểm tra thường xuyên của sinh viên
- DiemGK: Điểm kiểm tra giữa kì của sinh viên
- DiemThi: Điểm thi cuối kì của sinh viên
- DiemTB: Điểm trung bình của sinh viên
- MaGV: Mã của giảng viên phụ trách môn học cần nhập điểm
- MaHK: Mã của học kỳ đang học
> T/g: Nguyễn Duy Thanh Tùng | Email: nguyenduythanhtung@gmail.com
