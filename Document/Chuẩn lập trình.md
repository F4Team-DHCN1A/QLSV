## QUI ĐỊNH CHUNG VỀ CHUẨN LẬP TRÌNH
### TỔ CHỨC TẬP TIN, THƯ MỤC
- Đặt tên tập tin ngắn gọn (độ dài tên tập tin nên <=8 ký tự)

- Lưu mỗi lớp trong một tập tin riêng biệt và tên tập tin phải trùng với tên lớp.

- Mỗi Namespace được đặt trong một thư mục riêng, phân cấp thư mục theo phân cấp
 của Namespace
### NGẮT DÒNG, THỤT VÀO ĐẦU DÒNG
- Khi một biểu thức quá dài, ta phải ngắt dòng biểu thức đó theo nguyên tắc sau:
o Ngắt sau dấu phẩy

o Ngắt sau phép toán

o Ngắt theo độ ưu tiên của các phép toán

o Canh lề dòng sau khi ngắt phải ngang bằng với dòng trên tại cùng độ ưu tiên 
của phép toán
- Các dòng lệnh cùng cấp phải đặt thẳng hàng (canh lề trái), các dòng lệnh cấp con

phải thụt vào 1 khoảng Tab so với dòng lệnh cấp cha.
### KHOẢNG TRẮNG
- Không được phép gõ 2 hoặc nhiều khoảng trắng liên tiếp nhau.

- Không được gõ khoảng trắng ở đầu dòng lệnh.

- Giữa các phép toán và toán hạng phải có khoảng trắng.

- Sau dấu phẩy phải có 1 khoảng trắng (trường hợp truyền tham số cho hàm).
### CHÚ THÍCH

- Chú thích 1 đoạn: sử dụng cặp dấu /* …. */

- Chú thích 1 dòng: sử dụng //
### ĐỊNH NGHĨA LỚP / INTERFACE

- Dấu “{“ phải được đặt ở dòng kế tiếp sau dòng định nghĩa lớp (hoặc khai báo phương
thức)

- Dấu “}” phải được đặt thẳng hàng với dấu “{“ tương ứng của nó và phải được đặt
trên 1 dòng riêng.

- Giữa tên phương thức và dấu “(“ phía sau không có khoảng trắng.

- Bên trong 1 lớp / Interface, dữ liệu + phương thức phải được nhóm lại và được đặt

theo trình tự sau:

o Biến public

o Biến cục bộ

o Các hàm xử lý sự kiện

o Các hàm tự tạo
(Có thể dùng #region để nhóm các biến, phương thức cùng loại lại với nhau)
### Dòng trống (Blank Lines)

- Giữa các phương thức trong 1 lớp phải có 1 dòng trống tách biệt.

- Giữa các phương thức và các thuộc tính phải có 1 dòng trống.

- Giữa các biến cục bộ và câu lệnh đầu tiên trong phương thức nên có 1 dòng
trống (để dễ đọc)

- Giữa các phần (section) bên trong 1 phương thức nên có 1 dòng trống (để dễ
đọc)
### QUI ƯỚC ĐẶT TÊN (Đặt tên biến như thế nào để chuẩn “clean code”)

* Tên mang mục đích
        

Tôi cho rằng đây là qui định bắt buộc và ưu tiên nhất. Hãy chọn tên biểu đạt được mục đích của nó. Điều này hoàn toàn đơn giản phải không? 
Thay vì muốn biểu hiện danh sách học sinh bằng biến list1 hãy dùng listdrug. Bởi vì list1 là 1 tên vô nghĩa , gây nhầm lẫn và lộn xộn cho người đọc.
* Tính nhất quán
         

Nếu bạn đã dùng user làm tên biến chỉ khách hàng, thì đừng sử dụng tên client ở những phần phía dưới. Chắc chắn điều này sẽ gây không ít phiền hà cho người đọc.


* Tránh những kí tự dư thừa
        

Tránh những kí tự đặt phía trước như tiền tố m_ hay thêm kiểu dữ liệu vào đầu tên biến. Tôi cảm thấy khá dư, không cần thiết lắm. 
       Trong lúc làm việc nhóm, tôi cũng loại bỏ những tiền tố và team tôi không phàn nàn gì lắm. Và tôi cũng không thấy ai trong nhóm dùng thế.
*	Tên Form
 -  Tên lớp phải là danh từ hoặc cụm danh từ
 -  Sử dụng cách viết hoa của Pascal 
	-  Bắt đầu bằng tiếp đầu ngữ: “ frm “
*	Tên control trên form
 -  Trên control nên được ngắn gọn, mô tả chức năng và công dụng của control đó trên form
 -  Sử dụng cách viết hoa của Pascal 
 -  Bắt đầu bằng tiếp đầu ngữ sau đây:
	
<table style="width:35%;">
            <tr>
                <td>Button 	</td>
                <td>btn</td>
            </tr>
            <tr>
                <td>ComboBox </td>
                <td>cbo</td>
            </tr>
            <tr>
                <td >Label</td>
                <td >lbl</td>
            </tr>
            <tr>
                <td>TextBox</td>
                <td>txt</td>
            </tr>
            <tr>
                <td>DataGridView</td>
                <td>dgv</td>
            </tr>
            <tr>
                <td>RadioButton</td>
                <td>rad</td>
            </tr>
            <tr>
                <td>GroupBox</td>
                <td>grp</td>
            </tr>
        </table>

> T/g: Nguyễn Minh Thuận | Email: sktthuan111@gmail.com
