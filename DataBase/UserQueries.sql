
------------------------------------------ ----------------------------------------------------------------DUPLICATE USER CHECK

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


------------------------------------------ ----------------------------------------------------------------ADD USER

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


------------------------------------------ ---------------------------------------------------------------- login

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


------------------------------------------ ---------------------------------------------------------------- updateInfo
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


------------------------------------------ ----------------------------------------------------------------delete user inf
-- ALTER PROCEDURE deleteUserInfo
-- (
--     @userId INTEGER,
-- 	@username 	VARCHAR(255),
--     @result INTEGER OUTPUT
-- )
-- AS
-- BEGIN
--     -- Update category to disable it (set enabled to 0)
--     UPDATE userInfo
--     SET enabled = 0, username = @username
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


------------------------------------------ ---------------------------------------------------------------- fetch user info
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

------------------------------------------ ---------------------------------------------------------------- checkDuplicateCategory

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