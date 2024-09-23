-- USE expenseTrackie;

-- -- STORED PROCEDURE

-- ------------------------------------ DUPLICATE USER CHECK

-- CREATE PROCEDURE checkDuplicateUser
-- (
-- 	@username VARCHAR(255),
-- 	@number VARCHAR(10),
-- 	@exists BIT OUTPUT
-- )
-- AS
-- BEGIN
-- 	-- Check if row exists with the given username or number, where enabled is 1
-- 	IF EXISTS (
-- 		SELECT 1
-- 		FROM userInfo
-- 		WHERE (username = @username OR number = @number)
-- 		AND enabled = 1
-- 	)
-- 	BEGIN	
-- 		SET @exists = 1;
-- 	END
-- 	-- Else condition
-- 	ELSE 
-- 	BEGIN	
-- 		SET @exists = 0;
-- 	END 
-- END


-- ------------------------------------ ADD USER

-- CREATE PROCEDURE addUser
-- (
-- 	@username VARCHAR(255) ,
-- 	@password VARCHAR(255)  ,
-- 	@number VARCHAR(10)  ,
-- 	@dateJoined DATE ,
-- 	@profilePicturePath VARCHAR(255),
-- 	@userId INTEGER OUTPUT
-- )
-- AS
-- BEGIN
-- 	INSERT INTO userInfo (username, password, number, dateJoined,profilePicturePath, enabled)
-- 	VALUES (@username, @password, @number, @dateJoined,@profilePicturePath, 1);

--     SET @userId = SCOPE_IDENTITY()
-- END


-- ---------------------------------- login

-- CREATE PROCEDURE logUserIn
-- (
--     @username VARCHAR(255) ,
--     @password VARCHAR(255) ,
--     @userId INTEGER OUTPUT
-- )
-- AS
-- BEGIN
--         SELECT @userId = id 
--         FROM userInfo
--         WHERE username = @username AND password = @password;

-- END


-- ------------------------------------ updateInfo
-- CREATE PROCEDURE updateUserInfo
-- (
-- 	@username VARCHAR(255) ,
-- 	@number VARCHAR(10)  ,
-- 	@password VARCHAR(255)  ,
-- 	@dailyLimit DECIMAL(10,2),
-- 	@profilePicturePath VARCHAR(255),
-- 	@userId INTEGER,
-- 	@result INTEGER OUTPUT
-- )
-- AS
-- BEGIN
-- 	UPDATE userInfo
--     SET username = @username, number = @number, [password] = @password, dailyLimit = @dailyLimit, profilePicturePath = @profilePicturePath
--     WHERE id = @userId

--     -- Check if the update was successful
--     IF @@ROWCOUNT > 0
--     BEGIN
--         -- If a row was affected, return success
--         SET @result = 1
--     END
--     ELSE
--     BEGIN
--         -- If no rows were affected, return failure
--         SET @result = 0
--     END
-- END


-- ------------------------------------------ delete user inf
-- CREATE PROCEDURE deleteUserInfo
-- (
--     @userId INTEGER,
--     @result INTEGER OUTPUT
-- )
-- AS
-- BEGIN
--     -- Update category to disable it (set enabled to 0)
--     UPDATE userInfo
--     SET enabled = 0
--     WHERE id = @userId

--     -- Check if the update was successful
--     IF @@ROWCOUNT > 0
--     BEGIN
--         -- If a row was affected, return success
--         SET @result = 1
--     END
--     ELSE
--     BEGIN
--         -- If no rows were affected, return failure
--         SET @result = 0
--     END
-- END


-- ----------------------------------- fetch user info
-- ALTER PROCEDURE fetchUserInfo
-- (
-- 	@id INTEGER 
-- )
-- AS 
-- BEGIN

-- 	SELECT username,[password],number,dateJoined,profilePicturePath,dailyLimit
-- 	FROM userInfo
-- 	WHERE id = @id AND enabled = 1

-- END

-- ------------------------------------ checkDuplicateCategory

-- CREATE PROCEDURE checkDuplicateCategory
-- (
--     @catName VARCHAR(100),
--     @userId INTEGER,
--     @exists  BIT OUTPUT
-- )
-- AS
-- BEGIN
--     IF EXISTS (
-- 		SELECT 1
-- 		FROM category
-- 		WHERE (catName = @catName AND userId = @userId) AND enabled = 1
-- 	)
-- 	BEGIN	
-- 		SET @exists = 1;
-- 	END
-- 	-- Else condition
-- 	ELSE 
-- 	BEGIN	
-- 		SET @exists = 0;
-- 	END 

-- END


-- ------------------------------------ addNewCategory

-- CREATE PROCEDURE addNewCategory
-- (
--     @catName VARCHAR(100),
--     @description VARCHAR(250),
--     @color varchar(7),
--     @userId INTEGER,

--     @catId INTEGER OUTPUT
-- )
-- AS
-- BEGIN

--     INSERT INTO category(userId,catName,[description],color,enabled)
--     VALUES (@userId,@catName,@description,@color,1);

--      SET @catId = SCOPE_IDENTITY()

-- END


-- ------------------------------------------ deletecategory

-- CREATE PROCEDURE deleteCategory
-- (
--     @catId INTEGER,
--     @userId INTEGER,
--     @result INTEGER OUTPUT
-- )
-- AS
-- BEGIN
--     -- Update category to disable it (set enabled to 0)
--     UPDATE category
--     SET enabled = 0
--     WHERE catId = @catId AND userId = @userId

--     -- Check if the update was successful
--     IF @@ROWCOUNT > 0
--     BEGIN
--         -- If a row was affected, return success
--         SET @result = 1
--     END
--     ELSE
--     BEGIN
--         -- If no rows were affected, return failure
--         SET @result = 0
--     END
-- END

-- ------------------------------------------- updateCategory
-- CREATE PROCEDURE updateCategory
-- (
-- 	@catName VARCHAR(100),
--     @description VARCHAR(250),
--     @color varchar(7),
-- 	@catId INTEGER,
--     @userId INTEGER,

-- 	 @result INTEGER OUTPUT
	
-- )
-- AS
-- BEGIN

-- 	UPDATE category
--     SET catName = @catName, [description] = @description, color = @color
--     WHERE catId = @catId AND userId = @userId

--     -- Check if the update was successful
--     IF @@ROWCOUNT > 0
--     BEGIN
--         -- If a row was affected, return success
--         SET @result = 1
--     END
--     ELSE
--     BEGIN
--         -- If no rows were affected, return failure
--         SET @result = 0
--     END

-- END

-- ------------------------------------ getCategoryby Id

-- CREATE PROCEDURE getCategory
-- (
-- 	@userId INTEGER
-- )
-- AS
-- BEGIN

-- 	SELECT catId, catName, description ,color
-- 	FROM category
-- 	WHERE userId = @userId AND enabled = 1

-- END


-- ---------------------------- getCategoryId by name
-- ALTER PROCEDURE getCategoryId
-- (
--     @catName VARCHAR(100),
--     @userId INTEGER,
--     @catId INTEGER OUTPUT
-- )
-- AS
-- BEGIN
--     SELECT @catId = catId
--     FROM category
--     WHERE catName = @catName AND userId = @userId AND  enabled = 1
-- END



-- ------------------------------------ insertExpense

-- CREATE PROCEDURE addNewExpense
-- (
-- 	 	@amount DECIMAL(10,2) ,
--         @remarks VARCHAR(255) ,
--         @dateAdded DATE ,
--         @timeAdded TIME ,

-- 		@catId INTEGER,
-- 		@userId INTEGER,

-- 		@eId INTEGER OUTPUT

-- )
-- AS
-- BEGIN
-- 		INSERT INTO expense(userId,catId,amount,remarks,dateAdded,timeAdded,enabled)
-- 		VALUES (@userId,@catId,@amount,@remarks,@dateAdded,@timeAdded,1)

-- 		SET @eId = SCOPE_IDENTITY()
-- END



-- --------------------------------------- getTotalOfDayAllCategory

-- CREATE PROCEDURE getTotalOfDayAllCategory
-- (
-- 	@userId INTEGER,
-- 	@dateAdded DATE,
-- 	@total DECIMAL(10,2) OUTPUT
-- )
-- AS
-- BEGIN

-- 	SELECT @total = SUM(amount)
-- 	FROM expense e
--     JOIN category c
--     on e.catId = c.catId
-- 	WHERE e.userId = @userId AND e.dateAdded = @dateAdded AND e.enabled = 1  and c.enabled = 1


-- END


-- --------------------------------------- getTotalOfMonthAllCategory

-- CREATE PROCEDURE getTotalOfMonth
-- (
-- 	@userId INTEGER,
-- 	@startingDate DATE,
-- 	@endingDate DATE,
-- 	@total DECIMAL(10,2) OUTPUT
-- )
-- AS
-- BEGIN

-- 	SELECT @total = SUM(amount)
--     FROM expense
--     WHERE userId = @userId 
--     AND (dateAdded BETWEEN @startingDate AND @endingDate)
--     AND enabled = 1;

-- END



-- ----------------------------------------- getUserExpenseAllCategory

-- CREATE PROCEDURE getUserExpenseAllCategory
-- (
-- 	@userId INTEGER,
-- 	@dateAdded DATE
-- )
-- AS
-- BEGIN

-- 		SELECT eId,remarks,timeAdded,amount,color
-- 		FROM expense e
-- 		JOIN category c
-- 		on e.catId = c.catId
-- 		WHERE e.userId = @userId 
-- 			AND e.enabled = 1
-- 			AND c.enabled = 1 
-- 			AND e.dateAdded = @dateAdded

-- END
















-- -- 	SELECT catId, catName, description ,color
-- -- 	FROM category
-- -- 	WHERE userId = @userId AND enabled = 1