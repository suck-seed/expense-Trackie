
------------------------------------ insertExpense

CREATE PROCEDURE addNewExpense
(
	 	@amount DECIMAL(10,2) ,
        @remarks VARCHAR(255) ,
        @dateAdded DATE ,
        @timeAdded TIME ,

		@catId INTEGER,
		@userId INTEGER,

		@eId INTEGER OUTPUT

)
AS
BEGIN
		INSERT INTO expense(userId,catId,amount,remarks,dateAdded,timeAdded,enabled)
		VALUES (@userId,@catId,@amount,@remarks,@dateAdded,@timeAdded,1)

		SET @eId = SCOPE_IDENTITY()
END





---------------------------------------------------------------------------------------------------------- delete expense

CREATE PROCEDURE deleteExpense
(
	@eId INTEGER,
	@userId INTEGER,
	@result INTEGER OUTPUT
)
AS
BEGIN
	UPDATE expense
    SET enabled = 0
    WHERE userId = @userId AND eId = @eId

    -- Check if the update was successful
    IF @@ROWCOUNT > 0
    BEGIN
        -- If a row was affected, return success
        SET @result = 1
    END
    ELSE
    BEGIN
        -- If no rows were affected, return failure
        SET @result = 0
    END
END



------------------------------------------ ---------------------------------------------------------------- getTotalOfDayAllCategory

CREATE PROCEDURE getTotalOfDayAllCategory
(
	@userId INTEGER,
	@dateAdded DATE,
	@total DECIMAL(10,2) OUTPUT
)
AS
BEGIN

	SELECT @total = SUM(amount)
	FROM expense e
    JOIN category c
    on e.catId = c.catId
	WHERE e.userId = @userId AND e.dateAdded = @dateAdded AND e.enabled = 1  and c.enabled = 1


END


------------------------------------------ ---------------------------------------------------------------- getTotalOfMonthAllCategory

CREATE PROCEDURE getTotalOfMonth
(
	@userId INTEGER,
	@startingDate DATE,
	@endingDate DATE,
	@total DECIMAL(10,2) OUTPUT
)
AS
BEGIN

	SELECT @total = SUM(amount)
    FROM expense
    WHERE userId = @userId 
    AND (dateAdded BETWEEN @startingDate AND @endingDate)
    AND enabled = 1;

END



------------------------------------------ ---------------------------------------------------------------- getUserExpenseAllCategory

CREATE PROCEDURE getUserExpenseAllCategory
(
	@userId INTEGER,
	@dateAdded DATE
)
AS
BEGIN

		SELECT eId,remarks,timeAdded,amount,color
		FROM expense e
		JOIN category c
		on e.catId = c.catId
		WHERE e.userId = @userId 
			AND e.enabled = 1
			AND c.enabled = 1 
			AND e.dateAdded = @dateAdded

END


