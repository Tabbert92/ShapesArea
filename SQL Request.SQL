SELECT p.ProductName, c.CategoryName 
FROM Products p
LEFT JOIN ProductsToCategories ptc ON p.ProductID = ptc.ProductID
LEFT JOIN Categories c ON ptc.CategoryID = c.CategoryID