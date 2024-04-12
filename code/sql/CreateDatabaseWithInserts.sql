Drop table if exists book_sales;
Drop table if exists books;
Drop table if exists users;


Create Table users(
	id int IDENTITY(1,1) primary key,
	name nvarchar(50),
	email nvarchar(50),
	password nvarchar(50)
);

Create Table books(
	ISBN nvarchar(50) primary key,
	title nvarchar(50),
	author nvarchar(50),
	sinopse nvarchar(500),
	quantity int
);

Create Table book_sales(
	id int IDENTITY(1,1) primary key,
	books_isbn nvarchar(50) foreign key REFERENCES books(ISBN),
	users_id int foreign key REFERENCES users(id),
	sale_date datetime
);

-- Inserts for the users table
INSERT INTO users (name, email, password)
VALUES
('John Doe', 'john@example.com', 'password123'),
('Jane Smith', 'jane@example.com', 'securepassword'),
('Alice Johnson', 'alice@example.com', 'p@ssw0rd'),
('Bob Brown', 'bob@example.com', 'strongpassword');

-- Inserts for the books table
INSERT INTO books (ISBN, title, author, sinopse, quantity)
VALUES
('9780132350884', 'Clean Code', 'Robert C. Martin', 'Even bad code can function. But if code isn’t clean, it can bring a development organization to its knees.', 10),
('9781593275846', 'Eloquent JavaScript', 'Marijn Haverbeke', 'A Modern Introduction to Programming', 15),
('9781491925547', 'Python Crash Course', 'Eric Matthes', 'A Hands-On, Project-Based Introduction to Programming', 20),
('9780134092669', 'Introduction to Algorithms', 'Thomas H. Cormen', 'The "bible" of the field, this book is comprehensive and covers a broad range of algorithms.', 8);

-- Inserts for the book_sales table
INSERT INTO book_sales (books_isbn, users_id, sale_date)
VALUES
('9780132350884', 1, '2024-04-01 10:30:00'),
('9781593275846', 2, '2024-04-02 14:45:00'),
('9781491925547', 3, '2024-04-03 11:20:00'),
('9780134092669', 4, '2024-04-04 09:15:00');
