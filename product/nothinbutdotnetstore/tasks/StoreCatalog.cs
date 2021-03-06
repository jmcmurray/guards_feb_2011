﻿using System.Collections.Generic;
using nothinbutdotnetstore.web.application;

namespace nothinbutdotnetstore.tasks
{
    public interface StoreCatalog
    {
        IEnumerable<Department> get_the_main_departments();
        IEnumerable<Product> get_products_belonging_to(Department parent_department);
        IEnumerable<Department> get_departments_belonging_to(Department parent_department);
    }
}