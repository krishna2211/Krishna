create database febDemo
CREATE procedure InsertEmp
   (  
    @empno int,  
    @ename varchar(50),  
    @desig varchar (50),
	@salary money
    )  
    AS  
    BEGIN  
    INSERT INTO emp(empno,ename,desig,salary) values (@empno,@ename,@desig,@salary);  
    RETURN  
    END  
CREATE PROC updateEmp
   (  
     @empno int,  
    @ename varchar(50),  
    @desig varchar (50),
	@salary money 
    )  
    AS  
    BEGIN  
    UPDATE emp SET ename=@ename,desig=@desig WHERE empno=empno;  
    RETURN  
    END  

CREATE PROC DeleteEmp
(  
  @empno int  
  )  
    AS  
    BEGIN  
    DELETE FROM emp WHERE empno=@empno
    RETURN  
    END  