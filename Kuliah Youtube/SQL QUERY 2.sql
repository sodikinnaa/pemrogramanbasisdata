CREATE TABLE barang (
id_brg VARCHAR (5) NOT NULL,
nama_brg VARCHAR (10) NOT NULL,
stok INT (5) NOT NULL,
PRIMARY KEY (id_brg)
) ENGINE = MYISAM;
CREATE TABLE pembelian (
id_pem INT (5) NOT NULL,
id_brg VARCHAR (5) NOT NULL,
jml_beli INT (5) NOT NULL,
PRIMARY KEY (id_pem)
) ENGINE = MYISAM;

INSERT INTO barang VALUES ("A01", "Modem", 6);

INSERT INTO pembelian VALUE(2,"A10",10);


SELECT * FROM pembelian;
SELECT * FROM barang;

DELETE FROM barang WHERE id_brg = id_brg;

DROP TRIGGER inkremenstok;

SELECT * FROM barang;

INSERT INTO barang VALUES
("A10","Mouse",10),
("A11","Keyboard",15),
("A12","DVD-RW",10),
("A13","Modem",6);

INSERT INTO pembelian VALUES(3,"A11",5);

UPDATE pembelian 
SET jml_beli = 20
WHERE `id_pem` = 3;








