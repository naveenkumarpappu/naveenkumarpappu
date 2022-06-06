create table ClientRental(ClientNo varchar(10),cName varchar(20),propertyNo varchar(10),pAddress varchar(30),rentStart varchar(10),rentFinish varchar(10),rent int,ownerNo varchar(10),oName varchar(20)
)

insert into ClientRental values('CR76','John kay','PG4','6 lawrence St,Glassgow','1-jul-00','31-Aug-01',350,'C040','Tina Murphy'),
('CR76','John kay','PG16','5 Novar Dr,Glassgow','1-Sep-02','1-Sep-02',450,'C093','Tony Shaw'),
('CR56','Aline Stewart','PG4','6 lawrence St,Glassgow','1-sep-99','10-Jun-00',350,'C040','Tina Murphy'),
('CR56','Aline Stewart','PG36','2 Manor Rd,Glassgow','10-Oct-00','1-Dec-01',370,'C093','Tony Shaw'),
('CR56','Aline Stewart','PG16','5 Novar Dr,Glassgow','1-Nov-02','1-Aug-03',450,'C093','Tony Shaw')

select * from clientrental