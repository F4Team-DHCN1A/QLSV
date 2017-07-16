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
![form mon h c](https://user-images.githubusercontent.com/27407242/28236404-e0fbda9c-694f-11e7-8c3b-f3d8def3b128.JPG)
- Chức năng: Quản lý các môn học trong quá trình học tập, bạn có thể Thêm/Sửa/Xóa thông tin các môn học.
- Hướng dẫn:
  <ul>
    <li>Nhập các thông tin Mã môn học, Tên môn học, chọn Giáo viên ở các ô tương ứng.</li>
    <li>Click lựa chọn các nút chức năng muốn thực hiện.</li>
    <li>Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh.</li>
  </ul>
- Lưu ý: Khi sửa không được sửa Mã môn học.
## 3) Quản lý sinh viên
![form sinh vien](https://user-images.githubusercontent.com/27407242/28236465-73324f4e-6951-11e7-98e3-7d40b4c6ef7f.JPG)
* Chức năng: Quản lý các thông tin của sinh viên, bạn có thể Thêm/Sửa/Xóa thông tin của sinh viên.
* Hướng dẫn:
  <ul>
    <li>Nhập các thông tin Mã sinh viên, Tên sinh viên, Ngày sinh, chọn Lớp, Khoa ở các ô tương ứng</li>
    <li>Click lựa chọn các nút chức năng muốn thực hiện.</li>
    <li>Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh.</li>
  </ul>
## 4) Quản lý điểm thi
![fform di m](https://user-images.githubusercontent.com/27407242/28236934-b1653ee6-695d-11e7-9b76-aaab9ecf185a.JPG)
* Chức năng: Quản lý các điểm của sinh viên gồm Điểm chuyên cần, Điểm kiểm tra (15'), Điểm Giữa kỳ, Điểm thi (cuối kỳ) và Điểm trung bình sẽ được tự động tính khi nhập vào các điểm kia.
* Hướng dẫn:
  <ul>
    <li>Chọn các thông tin Học kỳ, Tên sinh viên, Tên môn học, Giảng viên và nhập các điểm vào ô tương ứng</li>
    <li>Click lựa chọn các nút chức năng muốn thực hiện.</li>
    <li>Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh.</li>
  </ul>
## 5) Quản lý Khoa/Lớp
![khoa](https://user-images.githubusercontent.com/27407242/28237080-4967c206-6961-11e7-9f8a-9849570d21d8.JPG)
![l p](https://user-images.githubusercontent.com/27407242/28237089-592e608c-6961-11e7-8738-4b1237637d07.JPG)
* Chức năng: Quản lý thông tin các Khoa hoặc Lớp trong trường học, bạn có thể Thêm/Sửa/Xóa thông tin các Khoa hoặc Lớp.
* Hướng dẫn:
  <ul>
    <li>Nhập các thông tin Mã Khoa/Lớp, Tên Khoa/Lớp ở các ô tương ứng</li>
    <li>Click lựa chọn các nút chức năng muốn thực hiện.</li>
    <li>Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh.</li>
  </ul>
## 6) Tìm kiếm
![tk](https://user-images.githubusercontent.com/27407242/28237093-63b5d418-6961-11e7-9729-71a59eb414a9.JPG)
![tkma](https://user-images.githubusercontent.com/27407242/28237113-cfe83fc2-6961-11e7-9cbb-ad72181ce3c1.JPG)
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
