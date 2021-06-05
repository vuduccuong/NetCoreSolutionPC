# Access Modifier (Phạm vi truy cập) trong C#
## Public
- Không hạn chế phạm vi truy cập. Thành phần mang thuộc tính này có thể <b>truy cập từ bất cứ đâu</b>

## Private
- Thành phần mang thuộc tính này là thành phần riêng tư <b>chỉ có nội bộ bên trong class mới có quyền truy cập</b>

## Protected
- Tương tự như <b>Private</b> ngoài ra còn có thể truy cập từ lớp dẫn xuất từ nó

## Internal
- <b>Chỉ được truy cập trong cùng 1 Assemply</b>(nói cách khác là cùng 1 project)
- Thuộc tính này thường được dùng cho class

## Protected internal
- Tương tự như <b>internal</b> ngoài ra còn có thể truy cập từ lớp dẫn xuất của lớp chứa nó