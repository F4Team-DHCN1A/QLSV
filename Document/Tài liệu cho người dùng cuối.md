# Tài liệu cho người dùng cuối

Đây là hướng dẫn sử dụng phần mềm cho người dùng

**_Để sử dụng phần mềm, bước đầu tiên bạn phải tạo một cơ sở dữ liệu (Sử dụng SQL Server) và dùng [SQL Query](https://github.com/F4Team-DHCN1A/QLSV/blob/master/qlsv.sql) này để tạo các table và các proceduce cần thiết cho phần mềm._**

## 1) Giao diện chính
### Khi bạn mở phần mềm sẽ đi tới giao diện chính của chương trình
![promain](https://user-images.githubusercontent.com/27407242/28236322-93654f9a-694d-11e7-8fec-37c9de4a5cd3.JPG)
- Chức năng: Chứa các menu chức năng. 
- Hướng dẫn: Click lựa chọn các chức năng để thực hiện.
## Sau đây là các chức năng của chương trình
## 2) Quản lý môn học
![mon h c](https://user-images.githubusercontent.com/27407242/28252965-ba188f32-6ac7-11e7-9308-e196bd46bee3.JPG)
- Chức năng: Quản lý các môn học trong quá trình học tập, bạn có thể Thêm/Sửa/Xóa thông tin các môn học.
- Hướng dẫn:
  <ul>
    <li>Nhập các thông tin Mã môn học, Tên môn học, chọn Giáo viên ở các ô tương ứng.</li>
    <li>Click lựa chọn các nút chức năng muốn thực hiện.</li>
    <li>Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh.</li>
  </ul>
- Lưu ý: Khi sửa không được sửa Mã môn học.
## 3) Quản lý sinh viên
![sinh vien](https://user-images.githubusercontent.com/27407242/28252986-d415f88e-6ac7-11e7-9756-f2d8dee021a3.JPG)
* Chức năng: Quản lý các thông tin của sinh viên, bạn có thể Thêm/Sửa/Xóa thông tin của sinh viên.
* Hướng dẫn:
  <ul>
    <li>Nhập các thông tin Mã sinh viên, Tên sinh viên, Ngày sinh, chọn Lớp, Khoa ở các ô tương ứng</li>
    <li>Click lựa chọn các nút chức năng muốn thực hiện.</li>
    <li>Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh.</li>
  </ul>
## 4) Quản lý điểm thi
![di m](https://user-images.githubusercontent.com/27407242/28252990-e15fe57c-6ac7-11e7-9513-fd81303f33cc.JPG)
* Chức năng: Quản lý các điểm của sinh viên gồm Điểm chuyên cần, Điểm kiểm tra (15'), Điểm Giữa kỳ, Điểm thi (cuối kỳ) và Điểm trung bình sẽ được tự động tính khi nhập vào các điểm kia.
* Hướng dẫn:
  <ul>
    <li>Chọn các thông tin Học kỳ, Tên sinh viên, Tên môn học, Giảng viên và nhập các điểm vào ô tương ứng</li>
    <li>Click lựa chọn các nút chức năng muốn thực hiện.</li>
    <li>Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh.</li>
  </ul>
## 5) Quản lý Khoa/Lớp
![khoa](https://user-images.githubusercontent.com/27407242/28253002-061090b0-6ac8-11e7-9336-62d6efd69cd5.JPG)
![l p](https://user-images.githubusercontent.com/27407242/28252995-f8055c6c-6ac7-11e7-8d15-27543a14487d.JPG)
* Chức năng: Quản lý thông tin các Khoa hoặc Lớp trong trường học, bạn có thể Thêm/Sửa/Xóa thông tin các Khoa hoặc Lớp.
* Hướng dẫn:
  <ul>
    <li>Nhập các thông tin Mã Khoa/Lớp, Tên Khoa/Lớp ở các ô tương ứng</li>
    <li>Click lựa chọn các nút chức năng muốn thực hiện.</li>
    <li>Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh.</li>
  </ul>
## 6) Tìm kiếm
![tk](https://user-images.githubusercontent.com/27407242/28253006-192f607c-6ac8-11e7-8490-04ef35b4b8d7.JPG)
* Chức năng: Tìm kiếm thông tin sinh viên, bạn có thể tìm bằng Mã sinh viên hoặc Tên sinh viên.
* Hướng dẫn:
  <ul>
    <li>Nhập các thông tin Mã sinh viên/Tên sinh viên muốn tìm vào ô tương ứng</li>
    <li>Các thông tin tìm kiếm được sẽ hiển thị tại bảng DataGridView bên dưới.</li>
  </ul>
* Lưu ý: Bạn có thể nhập tên/mã gần đúng các sinh viên
## 7) Báo cáo
![bc_diem](https://user-images.githubusercontent.com/27407242/28237121-f598d362-6961-11e7-9a9d-81b59dcc491a.JPG)
* Chức năng: Đưa ra các bản in về Danh sách các sinh viên trong 1 lớp/khoa, in điểm các sinh viên theo 1 lớp.
* Hướng dẫn: 
  <ul>
    <li>Nhập các thông tin Mã Lớp/Khoa ở các ô tương ứng</li>
    <li>Click lựa chọn các nút chức năng muốn thực hiện.</li>
    <li>Các thông tin bạn vừa xử lý sẽ được hiển thị trước để bạn có thể xem qua trước khi in</li>
  </ul>
> T/g: Nguyễn Duy Thanh Tùng | Email: nguyenduythanhtung@gmail.com
