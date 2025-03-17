using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        DataImporter importer = new DataImporter();
        
        importer.AddEmail("user1@example.com");
        importer.AddEmail("user2@example.com");
        importer.AddEmail("user1@example.com");
        importer.AddEmail("user3@example.com");
    }
}
