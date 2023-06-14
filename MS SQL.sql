CREATE TABLE Goods ( id INTEGER PRIMARY KEY, name VARCHAR(20), hint TEXT )
CREATE TABLE Category ( id INTEGER PRIMARY KEY, name VARCHAR(20))
Create TABLE GoodsCategoryLink ( id INTEGER PRIMARY KEY, goodsId INTEGER, categoryId INTEGER )

INSERT INTO Goods (
    id,
    name,
    hint
)
VALUES
    (
        1,
        'Milk',
        'By Cow'
    ),
    (
      	2,
      	'Meat',
      	'By Cow also'
    ),
    (
      	3, 
      	'Bread',
      	'White'
    ),
    (
      	4,
      	'T-short',
      	'For boy'
    ),
    (
      	5,
      	'Cigarettes',
      	'Dangerous for life'
    );  
    
    
INSERT INTO Category (
    id,
    name
)
VALUES
    (
        1,
        'Drinks'
    ),
    (
      	2,
      	'Foods'
    ),
    (
      	3, 
      	'Clothes'
    );  
    
INSERT INTO GoodsCategoryLink (
    id,
    goodsId,
  	categoryId
)
VALUES
    (
        1,
        1,
      	1
    ),
    (
      	2,
      	2,
      	2
    ),
    (
      	3, 
      	3,
      	2
    ),
    (
      	4,
      	4,
      	3
    ); 
    
Select Goods.name, ct.name from Goods
LEFT JOIN GoodsCategoryLink link ON Goods.id = link.goodsId
LEFT JOIN Category ct On link.categoryId = ct.id
