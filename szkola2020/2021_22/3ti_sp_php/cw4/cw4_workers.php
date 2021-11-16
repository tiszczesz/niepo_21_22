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


                <div class="list-group">
                    <a class='list-group-item list-group-item-action' href='cw4_workers.php'>Pracownicy</a>
                    <a class='list-group-item list-group-item-action' href='cw4_sections.php'>Sekcje</a>
                </div>

            </section>
            <section class="content col-9">
                <?php
                require_once "libs/Repository.php";
                require_once "libs/ToHtml.php";
                ?>
                <h4>Pracownicy</h4>
                <form action="saveworker.php" method="post">
                    <div class="form-group">
                        <label for="firstname">Podaj imię:</label>
                        <input class="form-control" type="text" name="firstname" id="firstname">
                    </div>
                    <div class="form-group">
                        <label for="lastname">Podaj nazwisko: </label>
                        <input class="form-control" type="text" name="lastname" id="lastname">
                    </div>
                    <div class="form-group">
                        <label for="salary">Podaj pensję: </label>
                        <input class="form-control" type="text" name="salary" id="salary">
                    </div>
                    <div class="form-group">
                        <label for="description">Opis: </label>
                        <textarea class="form-control" type="text" name="description" id="description" rows="3" cols="5"></textarea>
                    </div>
                    <div class="form-group">
                        <label for="section">Dział: </label>
                        <select name="section">
                            <?php
                             $repo = new Repository("localhost","root",null,"3ti_sp_cw4_x2021");
                             $sections = $repo->getAllSections();
                             var_dump($sections);
                             echo ToHtml::SectionsToSelect($sections) ; 
                             ?>
                        </select>
                    </div>
                    <div class="form-group">                        
                        <input class="btn btn-primary w-100" type="submit" value="Zapisz">
                    </div>
                </form>
                <?php


                ?>
            </section>
        </section>


    </section>

    <script src="bootstrap-5.0.2-dist/js/bootstrap.bundle.js"></script>
    <script src="cw4.js"></script>
</body>

</html>