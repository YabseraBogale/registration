create table User(
	
	userid int not null primary key,
	firstname varchar(30) not null,
	middlename varchar(30) not null,
	lastname varchar(30) not null,
	gender varchar(1) not null,
	dateofbirth datetime not null

)


create table Admin(
	userid int not null primary key,
	password varchar(30) not null,
	FOREIGN KEY (userid) REFERENCES User(userid)
)


create table Course(

	courseid int not null primary key,
	name varchar(30) not null,
	ch_hour int not null
	
)


create table Instructor(

	userid int not null primary key,
	password varchar(30) not null,
	courseid int not null,
	FOREIGN KEY (userid) REFERENCES User(userid),
	FOREIGN KEY (courseid) REFERENCES Course(courseid)
	
)

create table Student(
	userid int not null primary key,
	password varchar(30) not null,
	courseid int not null,
	instructor_id int not null,
	FOREIGN KEY (userid) REFERENCES User(userid),
	FOREIGN KEY (courseid) REFERENCES Course(courseid),
	FOREIGN KEY (instructor_id) REFERENCES Instructor(userid)
)



























