Select * from UserInfo where UserName=@username
Insert into UserInfo (FullName,UserName,Password) values(@FullName,@UserName,@Password)