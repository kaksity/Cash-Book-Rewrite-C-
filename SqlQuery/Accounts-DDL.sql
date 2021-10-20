CREATE TABLE ACCOUNTS
(
  ACCOUNTID varchar(200) NOT NULL,
  ACCOUNTNAME varchar(255) NOT NULL,
  ACCOUNTNUMBER varchar(255) NOT NULL,
  BANKNAME varchar(255),
  OPENINGDATE date NOT NULL,
  DESCRIPTION varchar(255),
  OPENINGBALANCE float NOT NULL,
  CURRENTBALANCE float NOT NULL,
  ISDELETED smallint NOT NULL,
  CREATEDAT timestamp NOT NULL,
  UPDATEDAT timestamp NOT NULL,
  CONSTRAINT PK_ACCOUNTS PRIMARY KEY (ACCOUNTID)
);

GRANT DELETE, INSERT, REFERENCES, SELECT, UPDATE
 ON ACCOUNTS TO  SYSDBA WITH GRANT OPTION;



