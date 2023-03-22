# Entity Framework Code loading related data

In this project have a litte overview about how load related data with entity framework core.

To load related entities, we have a three ways with entity framework core:

-   **[Eager loading](https://learn.microsoft.com/en-us/ef/core/querying/related-data/eager)**  means that the related data is loaded from the database as part of the initial query.
-   **[Explicit loading](https://learn.microsoft.com/en-us/ef/core/querying/related-data/explicit)**  means that the related data is explicitly loaded from the database at a later time.
-   **[Lazy loading](https://learn.microsoft.com/en-us/ef/core/querying/related-data/lazy)**  means that the related data is transparently loaded from the database when the navigation property is accessed.
