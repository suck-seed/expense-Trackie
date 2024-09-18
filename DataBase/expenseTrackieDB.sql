CREATE DATABASE expenseTrackie;


-- ABOUT USER (RUN THIS)

CREATE TABLE userInfo(

        id INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL ,
        username VARCHAR(255) UNIQUE NOT NULL,
        password VARCHAR(255) NOT NULL ,
        number VARCHAR(10) UNIQUE NOT NULL,
        dateJoined DATE NOT NULL,
        enabled BIT NOT NULL DEFAULT 1,

        

);

ALTER TABLE userInfo
ADD profilePicturePath VARCHAR(255) NULL;

select * from userInfo


--  insertion testing
INSERT INTO userInfo (username, password, number, dateJoined, enabled)
VALUES ('johndoe', '1234', '1234567890', '2024-09-14', 1);



-- (RUN THIS)
CREATE TABLE userAttributes(
        id INTEGER NOT NULL,
        dailyLimit DECIMAL(10,2) CONSTRAINT def_limit DEFAULT 5000,

        PRIMARY KEY (id),
        FOREIGN KEY (id) REFERENCES userInfo(id)

        
);

-- (RUN THIS)
CREATE TABLE verification(
        id INTEGER NOT NULL,

        PRIMARY KEY(id),
        FOREIGN KEY (id) REFERENCES userInfo(id)
        

);




-- ABOUT CATEGORY (RUN THIS)

CREATE TABLE category(
        catId INTEGER IDENTITY(1,1) ,

       
        catName VARCHAR(100)  NOT NULL ,
        description VARCHAR(250) NOT NULL,
        color varchar(7) NOT NULL,
        userId INTEGER NOT NULL,
        enabled BIT NOT NULL DEFAULT 1,


        PRIMARY KEY (catId),
        FOREIGN KEY (userId) REFERENCES userInfo(id)

);


--  DO NOT RUN THIS
-- ALTER TABLE category
-- ALTER COLUMN color varchar(7);

-- DELETE FROM category
-- WHERE catId = 4
SELECT * from category



-- -- EXPENSES (RUN THIS)
CREATE TABLE expense(
        eId INTEGER IDENTITY(1,1),
        userId INTEGER NOT NULL,
        catId INTEGER NOT NULL,

        amount DECIMAL(10,2) NOT NULL,
        remarks VARCHAR(255) NOT NULL,
        dateAdded DATE NOT NULL,
        timeAdded TIME NOT NULL,
        enabled BIT NOT NULL DEFAULT 1,


        PRIMARY KEY(eId),
        FOREIGN KEY (userId) REFERENCES userInfo(id),
        FOREIGN KEY (catId) REFERENCES category(catId),

     

);







SELECT * from   expense

-- for tyo custom expense button jasto
SELECT eId,remarks,timeAdded,color,amount
from expense e
JOIN category c
on e.catId = c.catId
WHERE e.userId = 1 AND c.userId = 1 AND c.enabled = 1 AND c.catId IN (2,3)







-- after you run all this, in project goto App.config, you can see this
-- <connectionStrings>
--     <add name="expenseTrackie"
--     connectionString="Data Source=NOTHINGS-LAPTOP\SQLEXPRESS;Initial Catalog=expenseTrackie;Integrated Security=True;"
--     providerName="System.Data.SqlClient" />
-- </connectionStrings>

-- 