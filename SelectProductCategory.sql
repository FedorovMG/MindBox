SELECT
	Product."Name_Product", Category."Name_Category"
FROM
	public."Products" AS Product LEFT JOIN public."Category" AS Category
	ON Product."ID_Category" = Category."ID_Category";