CREATE TABLE SUPPORTINGDOCUMENTS
(
  SUPPORTINGDOCUMENTID varchar(200) NOT NULL,
  TRANSACTIONID varchar(200) NOT NULL,
  DOCUMENTNAME varchar(255) NOT NULL,
  DESCRIPTION varchar(255) NOT NULL,
  DOCUMENT blob sub_type 0 NOT NULL,
  ISDELETED smallint NOT NULL,
  CREATEDAT timestamp NOT NULL,
  UPDATEDAT timestamp NOT NULL,
  CONSTRAINT PK_SUPPORTINGDOCUMENTS PRIMARY KEY (SUPPORTINGDOCUMENTID)
);

ALTER TABLE SUPPORTINGDOCUMENTS ADD CONSTRAINT FK_SUPPORTINGDOCUMENTS_TRANS
  FOREIGN KEY (TRANSACTIONID) REFERENCES TRANSACTIONS (TRANSACTIONID);
GRANT DELETE, INSERT, REFERENCES, SELECT, UPDATE
 ON SUPPORTINGDOCUMENTS TO  SYSDBA WITH GRANT OPTION;




