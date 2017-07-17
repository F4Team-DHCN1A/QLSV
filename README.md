# PHẦN MỀM QUẢN LÝ SINH VIÊN
![a](https://user-images.githubusercontent.com/27596661/28235914-d6ff2b0a-6942-11e7-8c61-2013b95c1303.PNG)
## Lời mở đầu
  Với sự phát triển nhanh chóng của công nghệ thông tin đã ra đời nhiều công cụ hữu ích giúp chúng ta tiết kiệm rất nhiều thời gian và chi phí. Nhiều phần mềm trong lĩnh vực công  nghệ thông tin nhanh chóng ra đời đã góp phần đáng kể. Chính vì vậy, mỗi công ty, mỗi cơ quan đều muốn xây dựng riêng cho mình một phần mềm quản lý.

  Để xây dựng một phần mềm có năng suất hoạt động tốt, cần có sự phối hợp về kiến thức cũng như ý tưởng của nhiều thành viên gộp lại. Vì vậy cần có một hệ thống quản lý phiên bản phân tán có thể giúp các thành viên dễ dàng trao đổi kiến thức cũng như code xây dựng phần mềm.
  
  Xuất phát từ những nhu cầu đó và theo yêu cầu môn học, nhóm chúng em xây dựng một phần mềm “Quản lý sinh viên” trên nền tảng ngôn ngữ lập trình C#, hệ quản trị cơ sở dữ liệu SQL và được xây dựng theo hướng phần mềm mã nguồn mở với các phiên bản được quản lý trên kho Github – một hệ thống quản lý phiên bản phân tán.
  
  `Mục tiêu` là nhằm tạo ra phần mềm Quản lý sinh viên với các chức năng cơ bản của một phần mềm quản lý, đồng thời nắm bắt được cách tổ chức mã nguồn theo mô hình 3 lớp và trao đổi code cũng như tài liệu xây dựng trên môi trường Github. 
  
  Qua đó tạo điều kiện cho các nhà `phát triển` có thể fix các lỗi và phát triển phần mềm tối ưu hơn, có thể áp dụng vào trong quá trình thực tế. Bởi lẽ do kiến thức còn hạn chế, ý tưởng chưa có nhiều nên phần mềm chưa được hoàn thiện.
## Thành viên nhóm thực hiện
1) Nguyễn Duy Thanh Tùng | MSSV: 14ĐC095 | SĐT: 01653841567
2) Lê Văn Cường | MSSV: 14ĐC110 | SĐT: 01652096045
3) Triệu Nam Dương | MSSV: 14ĐC017  | SĐT: 01636630894
4) Nguyễn Minh Thuận | MSSV: 14ĐC084 | SĐT: 01695183671
## Giấy Phép
Vui lòng xem tại [MIT License](https://github.com/F4Team-DHCN1A/QLSV/blob/master/LICENSE) Copyright © 2017 F4 Team - Telecommunications University

Giấy phép MIT là một loại giấy phép sử dụng cho các phần mềm, các mã nguồn mở được phát triển dựa trên một loại giấy phép có nguồn gốc tại Viện Công nghệ Massachusetts (MIT).

Giấy phép MIT là loại giấy phép cho phép sử dụng mã nguồn tự do nhất, nó có thể kết hợp với các mã nguồn khác và đảm bảo tương thích tuân theo điều kiện của mọi lại giấy phép khác. Ví dụ nó có thể kết hợp với một phần mã nguồn được cung cấp bởi Giấy phép GPL và hoàn toàn cho phép phát triển theo giấy phép GPL. Đơn giản vì nó cho phép sử dụng mã nguồn tự do hơn cả Giấy phép GPL.

Giấy phép MIT còn có tên gọi khác là giấy phép X11, Giấy phép MIT đã được sử dụng nhiều cho các phần mềm cho các hệ thống X Window.
## Thông tin tổ chức mã nguồn 
![a](https://user-images.githubusercontent.com/27596661/28235728-3a03d372-693e-11e7-80e3-f40cba1c35f4.png)
![a](https://user-images.githubusercontent.com/27596661/28235747-afaa6334-693e-11e7-86c3-b8993361b441.png)

#### Mã nguồn được phân chia theo 3 Tầng như sau: 

* Tầng `QuanLySinhVien_BLL` chứa các module xử lý các sự kiện trong từng Form giao diện, file *xulichuoi.cs* đảm nhiệm việc định dạng dữ liệu vào theo chuẩn


* Tầng `QuanLySinhVien_BLL` chứa các module dữ liệu, file *DB_connect.cs* chứa kết nối đến **CSDL**, file *Data.cs* chứa dữ liệu từ các bảng trong  **CSDL**


* Tầng `QuanLySinhVien_GUI` chứa các Form giao diện, *frmProMain.cs* trong tầng này sẽ là chương trình chính gọi tất cả các Form khác khi click sự kiện.

> T/g: Lê Văn Cường
## Nền tảng xây dựng
#### [C# .NET](https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework) - Nền tảng hệ thống phần mềm
* C # là một ngôn ngữ lập trình hiện đại được phát triển bởi Microsoft và được phê duyệt bởi European Computer Manufacturers Association (ECMA) và International Standards Organization (ISO).

* C # được phát triển bởi Anders Hejlsberg và nhóm của ông trong việc phát triển .Net Framework.

* C # được thiết kế cho các ngôn ngữ chung cơ sở hạ tầng (Common Language Infrastructure – CLI), trong đó bao gồm các mã (Executable Code) và môi trường thực thi (Runtime Environment) cho phép sử dụng các ngôn ngữ cấp cao khác nhau trên đa nền tảng máy tính và kiến trúc khác nhau.

#### Ngôn ngữ ra đời cùng với .NET

* Kết hợp C++ và Java. Hướng đối tượng. Hướng thành phần. Mạnh mẽ (robust) và bền vững (durable). Mọi thứ trong C# đều Object oriented. Kể cả kiểu dữ liệu cơ bản. Chỉ cho phép đơn kế thừa. Dùng interface để khắc phục. Lớp Object là cha của tất cả các lớp. Mọi lớp đều dẫn xuất từ Object. Cho phép chia chương trình thành các thành phần nhỏ độc lập nhau. Mỗi lớp gói gọn trong một file, không cần file header như C/C++. Bổ sung khái niệm namespace để gom nhóm các lớp. Bổ sung khái niệm “property” cho các lớp. Khái niệm delegate & event

* Vai trò C# trong .NET Framework.NET runtime sẽ phổ biến và được cài trong máy client. Việc cài đặt App C# như là tái phân phối các thành phần .NET Nhiều App thương mại sẽ được cài đặt bằng C#.

* C# tạo cơ hội cho tổ chức xây dựng các App Client/Server n-tier. Kết nối ADO.NET cho phép truy cập nhanh chóng & dễ dàng với SQL Server, Oracle… Cách tổ chức .NET cho phép hạn chế những vấn đề phiên bản.

#### [MS SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2016) - Nền tảng cơ sở dữ liệu
* SQL Server là một hệ quản trị cơ sở dữ liệu quan hệ (Relational Database Management System (RDBMS) ) sử dụng câu lệnh SQL (Transact-SQL) để trao đổi dữ liệu giữa máy Client và máy cài SQL Server. Một RDBMS bao gồm databases, database engine và các ứng dụng dùng để quản lý dữ liệu và các bộ phận khác nhau trong RDBMS.

* SQL Server được tối ưu để có thể chạy trên môi trường cơ sở dữ liệu rất lớn (Very Large Database Environment) lên đến Tera-Byte và có thể phục vụ cùng lúc cho hàng ngàn user. SQL Server có thể kết hợp “ăn ý” với các server khác như Microsoft Internet Information Server (IIS), E-Commerce Server, Proxy Server….
> T/g: Nguyễn Minh Thuận
## Chuẩn lập trình
* Để xem Chuẩn lập trình, Vui lòng tham khảo [tại đây](https://github.com/F4Team-DHCN1A/QLSV/blob/master/Document/Chu%E1%BA%A9n%20l%E1%BA%ADp%20tr%C3%ACnh.md)
## Tài liệu cho người dùng cuối
* Để xem tài liệu cho người dùng cuối, Vui lòng tham khảo [tại đây](https://github.com/F4Team-DHCN1A/QLSV/blob/master/Document/T%C3%A0i%20li%E1%BB%87u%20cho%20ng%C6%B0%E1%BB%9Di%20d%C3%B9ng%20cu%E1%BB%91i.md)
## Tài liệu cho nhà phát triển
* Để xem tài liệu cho nhà phát triển, Vui lòng tham khảo [tại đây](https://github.com/F4Team-DHCN1A/QLSV/blob/master/Document/T%C3%A0i%20li%E1%BB%87u%20danh%20cho%20nh%C3%A0%20ph%C3%A1t%20tri%E1%BB%83n.md)
## Tài liệu thiết kế
* Để xem tài liệu thiết kế, Vui lòng tham khảo [tại đây](https://github.com/F4Team-DHCN1A/QLSV/blob/master/Document/T%C3%A0i%20li%E1%BB%87u%20thi%E1%BA%BFt%20k%E1%BA%BF.md)
## Danh sách lỗi
- Giao diện chưa đẹp,
- Thiết kế dữ liệu chưa hợp lý.
Phần mềm chưa được hoàn thiện, hy vọng các bạn đóng góp ý kiến hay update danh sách các lỗi [tại đây](https://github.com/F4Team-DHCN1A/QLSV/issues) để nhóm hay các nhà phát triển khác có thể hoàn thiện sản phẩm hơn.
> T/g: Lê Văn Cường
## Cách lấy mã và đóng góp mã nguồn
* Các bạn [click vào đây](https://github.com/F4Team-DHCN1A/QLSV/archive/master.zip) để Download mã nguồn,

* Để đóng góp mã nguồn hay phản hồi [tại đây](https://github.com/F4Team-DHCN1A/QLSV/issues) hoặc gửi vào hộp thư điện tử `lecuong15796@gmail.com`.

> T/g: Lê Văn Cường
## Kênh truyền thông cho dự án
Nhằm tạo ra phần mềm đầy đủ, hoàn thiện và có chất lượng cao, dự án được chia sẻ trên lên internet dưới dạng mã nguồn mở để mọi người cùng tham gia đánh giá, nhận xét cũng như xây dựng phần mềm hoàn thiện hơn.

1.	Trang [facebook](https://www.facebook.com/%E1%BB%A8ng-d%E1%BB%A5ng-ph%E1%BA%A7n-m%E1%BB%81m-qu%E1%BA%A3n-l%C3%BD-sinh-vi%C3%AAn-107568713233555/) của dự án, Luôn tiếp nhận các ý kiến đóng góp từ cộng đồng

2.	Trên Website [Sharecode.vn](https://sharecode.vn/source-code/phan-mem-quan-ly-sinh-vien-13414.htm) cho mọi người cần tham khảo và đóng góp

> T/g: Triệu Nam Dương
## Lời cảm ơn
Để hoàn thành tốt đề tài này chúng em xin cảm ơn thầy **Mai Cường Thọ** – giảng viên khoa CNTT Trường Đại học Nha Trang cùng các thầy cô 
**Bộ môn Mạng** đã hướng dẫn tạo điều kiện cho chúng em nghiên cứu và hoàn thành đề tài. Tuy nhiên do mới làm quen với hệ thống quản lý phiên bản phân tán Github và kiến thức C# còn hạn chế nên đồ án môn học của chúng em còn nhiều thiếu sót, chúng em mong nhận được sự góp ý từ thầy **Mai Cường Thọ** và các thầy cô giáo bộ môn để chúng em có thể hoàn thiện đồ án một cách tốt nhất.

**_Một lần nữa, chúng em xin chân thành cảm ơn!_**
