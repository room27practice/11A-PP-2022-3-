SELECT * FROM Countries
WHERE CountryName LIKE 'B%'  
AND (ContinentCode LIKE 'AF' OR ContinentCode LIKE 'EU')
 
 SELECT CountryName,Population,Capital,ContinentCode AS 'Континент' FROM Countries
 WHERE  ContinentCode NOT IN ('NA','AF','EU')

 SELECT * FROM Continents