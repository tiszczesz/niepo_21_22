<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="bootstrap-5.0.2-dist/css/bootstrap.css">
    <link rel="stylesheet" href="cw4.css">
    <title>Ćwiczenie 4 McD</title>
</head>

<body>
    <section class="container">
    <a class="baner-link" href="cw4.php">
            <section class="baner">
                <h1 class="display-1 bg-secondary p-2 fw-bold text-center text-light">OBSŁUGA SKLEPU McD</h1>
            </section>
        </a>

        <section class="main row">
            <section class="menu col-3">
                
                   
                    <?php
                        require_once "libs/Repository.php";
                        require_once "libs/ToHtml.php";
                        $id = filter_has_var(INPUT_GET,"id")? filter_input(INPUT_GET,"id"): null;
                        $repo = new Repository("localhost","root",null,"3ti_sp_cw4_x2021");
                        $sections = $repo->GetAllSections();
                        echo ToHtml::SectionsToList($sections,$id);
                    ?>  
               
               <hr>
               <div class="list-group">
               <a class='list-group-item list-group-item-action' href='cw4_workers.php'>Pracownicy</a>
               <a class='list-group-item list-group-item-action' href='cw4_sections.php'>Sekcje</a>
               </div>

            </section>
            <section class="content col-9">
                dfgf
                <?php
                     
                        $workers = $repo->getWorkers($id);
                        //var_dump($workers);
                        echo ToHtml::WorkersToTable($workers);
                ?>
            </section>
        </section>


    </section>

    <script src="bootstrap-5.0.2-dist/js/bootstrap.bundle.js"></script>
    <script src="cw4.js"></script>
</body>

</html>