Reproduces a bug in Entity Framework 5.0 Code First Migrations.

At Commit 2, "Initial FK Relationships - prepare the problem," the database is working - a call to update-database -f -verbose will get you a working schema in your SQL Server (or Express) instance.

Move to Commit 3, "Kaboom - Migration fails" and run update-database -f -verbose to see Migrations fail to generate the proper SQL.

The PK on the child table "Version" has changed, which has forced the FK pointing at it from MyClass to change. The SQL generated fails to take account of this, and SQL Server rejects the changes, causing Migrations to throw an Exception and leaving the developer in the lurch.

This can be worked around by:

1) Commenting out the FK relationships between the 2 tables and the new Id (and any and all code in the project that uses these relationships or this Id, which could be significant).

2) Running update-database -f to force Migrations to delete the problem relationships in the schema.

3) Adding the Id property and running update-database again to force Migrations to recognize the switch in PK.

4) Finally adding the relationships back and running update-database one more time to allow Migrations to proceed with a scenario it's used to handling.