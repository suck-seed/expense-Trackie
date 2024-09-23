
------------------------------------------ ----------------------------------------------------------------addNewCategory

CREATE PROCEDURE addNewCategory
(
    @catName VARCHAR(100),
    @description VARCHAR(250),
    @color varchar(7),
    @userId INTEGER,

    @catId INTEGER OUTPUT
)
AS
BEGIN

    INSERT INTO category(userId,catName,[description],color,enabled)
    VALUES (@userId,@catName,@description,@color,1);

     SET @catId = SCOPE_IDENTITY()

END


------------------------------------------ ----------------------------------------------------------------deletecategory

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

------------------------------------------ ---------------------------------------------------------------- updateCategory
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

------------------------------------------ ----------------------------------------------------------------getCategoryby Id

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


------------------------------------------ ----------------------------------------------------------------getCategoryId by name
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
