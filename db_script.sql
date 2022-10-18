create table Users (
        User_Id Number(5) Primary Key,
        First_Name varchar2(15),
        Last_Name varchar2(15),
        Phone_Number Number(15) Unique Not Null,
        User_Password varchar2(20) Not Null
);

create sequence User_Id_Sequence
start with 1
increment by 1;

create table Complaints (
        Complaint_Id Number(5) Primary Key,
        Complaint_Title varchar2(55),
        Complaint_Text varchar2(1000),
        Complaint_Datetime DATE,
        Is_Answered Number(1),
        User_Id Number(5) references Users (User_Id) ON DELETE CASCADE
);

create sequence Complaint_Id_Seq
start with 1
increment by 1;

insert into Complaints Values(Complaint_Id_Seq.nextval, 'Complaint_Title1', 'Complaint_Text1', To_DATE('17/12/2015', 'DD/MM/YYYY'), 0, 2);
insert into Complaints Values(Complaint_Id_Seq.nextval, 'Complaint_Title2', 'Complaint_Text2', To_DATE('16/12/2015', 'DD/MM/YYYY'), 1, 3);
insert into Complaints Values(Complaint_Id_Seq.nextval, 'Complaint_Title3', 'Complaint_Text3', To_DATE('15/12/2015', 'DD/MM/YYYY'), 0, 4);
insert into Complaints Values(Complaint_Id_Seq.nextval, 'Complaint_Title4', 'Complaint_Text4', To_DATE('14/12/2015', 'DD/MM/YYYY'), 0, 5);
insert into Complaints Values(Complaint_Id_Seq.nextval, 'Complaint_Title5', 'Complaint_Text5', To_DATE('13/12/2015', 'DD/MM/YYYY'), 1, 3);
insert into Complaints Values(Complaint_Id_Seq.nextval, 'Complaint_Title6', 'Complaint_Text6', To_DATE('12/12/2015', 'DD/MM/YYYY'), 1, 1);

create table Saved_Places (
        Place_Id Number(5) Primary Key,
        Place_Name varchar2(255),
        Latitude Number(20, 10),
        Longitude Number(20, 10),
        User_Id Number(5) not null references Users (User_Id) ON DELETE CASCADE
);

create sequence Saved_Places_Id_Seq
start with 1
increment by 1;

insert into Saved_Places Values(Saved_Places_Id_Seq.nextval, 'Place_Name1', 1.1, 1.1, 2);
insert into Saved_Places Values(Saved_Places_Id_Seq.nextval, 'Place_Name2', 1.2, 1.2, 3);
insert into Saved_Places Values(Saved_Places_Id_Seq.nextval, 'Place_Name3', 1.3, 1.3, 4);
insert into Saved_Places Values(Saved_Places_Id_Seq.nextval, 'Place_Name4', 1.4, 1.4, 5);
insert into Saved_Places Values(Saved_Places_Id_Seq.nextval, 'Place_Name5', 1.5, 1.5, 3);
insert into Saved_Places Values(Saved_Places_Id_Seq.nextval, 'Place_Name6', 1.6, 1.6, 1);

create or replace procedure GetComplaintById 
(Id in Number, Title out VARCHAR2, Text out VARCHAR2,
Datetime out Date, IsAnswered out Number, UserId out NUMBER )
as 
BEGIN
select complaint_title, complaint_text, complaint_datetime, is_answered, user_id
into Title, Text, Datetime, IsAnswered, UserId
from complaints 
where complaint_id = Id;
end;

create or replace procedure GetComplaintsByDate 
(Complaint_DT in Date, Complaints out sys_refcursor)
as 
BEGIN
open Complaints for 
select *
from complaints
where to_char(Complaint_Datetime, 'yyyy-MM-dd') = to_char(Complaint_DT, 'yyyy-MM-dd');
end;

