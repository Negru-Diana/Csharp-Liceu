-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 18, 2023 at 08:34 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `softeducational`
--

-- --------------------------------------------------------

--
-- Table structure for table `capitole`
--

CREATE TABLE `capitole` (
  `idC` int(11) NOT NULL,
  `Titlu` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `capitole`
--

INSERT INTO `capitole` (`idC`, `Titlu`) VALUES
(1, 'Începuturile'),
(2, 'Sclavul și sclavia'),
(3, 'Emanciparea'),
(4, 'Personalități emblematice');

-- --------------------------------------------------------

--
-- Table structure for table `continut_lectii`
--

CREATE TABLE `continut_lectii` (
  `id` int(11) NOT NULL,
  `idL` int(11) NOT NULL,
  `continut` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `continut_lectii`
--

INSERT INTO `continut_lectii` (`id`, `idL`, `continut`) VALUES
(1, 1, 'modificare'),
(2, 2, '     Sclavia (din termenul  medieval sclavus < slavus) desemnează condiția umană a persoanelor (sclavii) care lucrează pentru un stăpân fără remunerație și ce nu dispun de drepturi asupra propriei persoane. Din punct de vedere istoric, sclavia înseamnă, prin definiție, negarea egalității între oameni, iar filozofic sclavii erau considerați o specie aparte și inferioară.\n     Istoria sclaviei se întinde pe mai multe culturi, naționalități și religii din cele mai vechi timpuri până în prezent. Cu toate acestea, pozițiile sociale, economice și juridice ale sclavilor au diferit foarte mult în diferite sisteme de sclavie în diferite perioade și locuri. Dovezile sclaviei sunt anterioare înregistrărilor scrise; practica a existat în multe, dacă nu chiar în majoritatea culturilor. Sclavia a avut loc în civilizații vechi ca Sumer, precum și în aproape orice altă civilizație antică, inclusiv Egiptul antic, China antică, Imperiul Akkadian, Asiria, Babilonia, Persia, Grecia antică, India antică Imperiul Akkadian, Asiria, Babilonia, Persia, Grecia antică, India antică, Imperiul Roman, Califatul arab islamic și Sultanatul, Nubia și civilizațiile precolumbiene ale Americii. Sclavia antică reprezintă un amestec de sclavie datorie, pedeapsă pentru crimă, înrobirea prizonierilor de război, abandonarea copiilor,și nașterea copiilor sclavi.\n     Inceputurile sclaviei pe continental Americii de Nord e legată de secolul al XVII-lea, de intemeierea primelor colonii . Sclavia populației afro-americane a avut un anumit impact în evoluția poporului american . Tema sclaviei, a mișcării aboliționiste și a procesului de emancipare a foștilor sclavi a fost intens analizată și dezbătută de-a lungul timpului în contextul american dintr-un amplu ansamblu de puncte de vedere,\n     Sclavia nu a fost considerată nici necesară şi nici profitabilă în primii ani de existenţă a coloniilor americane. Slujitorii angajaţi de funcţionari erau în primă fază cei care îndeplineau diferite munci în interiorul coloniilor. Sclavia în America a început, iniţial, prin deportarea în colonia Virginia a diferiţilor indivizi care au încălcat legea în Metropola britanică. În general infractorii din Anglia puteau fi pedepsiţi prin 3 moduri: biciurea şi trimiterea înapoi în parohia de unde au venit, înrolarea forţată în expediţii militare sau deportarea în colonii.Odată ajunşi în colonii, aceşti deportaţi trebuiau să presteze diferite munci pentru colonişti, în schimbul cărora erau slab remuneraţi.\n     Riscul unei rebeliuni în interiorul coloniei era unul foarte crescut.Ambiţia proprietarilor de teren de a face profituri cât mai repede şi cât mai uşor a instaurat cu paşi repezi, sclavia în statul Virginia. Cei care slujeau de mai mult timp pe plantaţiile de tutun din Virginia au devenit treptat subiecţii unor pedepse din ce în ce mai aspre în caz de fugă. În Virginia, din 1620, astfel de lucrători au ajuns să fie vânduţi şi cumpăraţi ca mărfuri. Odată ce sclavia a ajuns să fie acceptată ca sistem de lucru, nici autoritatea centrală nu mai dorea să renunţe la avantajele care proveneau din menţinerea ei (acoperirea necesarului de forţă de muncă, supraproducţie şi  pieţe libere)\n     Istoria sclavilor afro-americani a început oficial pe 20 august 1619, atunci când o navă olandeză a adus în  Jamestown (Virginia) 20 de sclavi de origine africană. Oficial, aceşti primi sclavi afro-americani au fost desemnaţi iniţial ca fiind ucenici. Proprietarul unei plantaţii de tutun, John Rolfe, consemnează evenimentul în jurnalul său: „Pe la sfârşitul lui august a venit un olandez şi ne-a vândut 20 de negri”.În primă fază, primii afro-americani îşi putea redobândi libertatea după 4 sau 7 ani în slujba stâpânului. După prima generaţie, slugilor afro-americane li s-a mărit treptat timpul de dependenţă, până când au devenit înrobiţi pe viaţă.Cea care se va implica activ în comerţul transatlantic cu slavi a fost Compania Indiilor de Vest (1621), o corporaţie ce a deţinut monopolul în acest domeniu. Așadar, incepând cu 1619, bărbații, femeile și copiii africani au fost răpiți din patria lor și expediați în condiții brutale către coloniile americane pentru a suporta o viață de dificultăți în robie ca sclavi. Dar sclavia a existat în fiecare parte din ceea ce este acum Statele Unite pentru mult mai mult timp, deoarece a început cu înrobirea popoarelor indigene odată cu sosirea colonizatorilor europeni. Înainte de sclavia africană, popoarele indigene din Caraibe au fost înrobite de Columb și de cuceritorii spanioli în 1492. Colonizatorii europeni precum spaniolii, francezii, olandezii, britanicii și rușii au aservit popoarele indigene în locuri precum , Alaska ,California  , Noua Anglie ,Caraibe . Scopul înrobirii unei alte ființe umane și continuarea practicii pentru o perioadă atât de lungă de timp a fost să câștigul financiar și să crearea unui sistem de ierarhie care să țină proprietarii de pământ albi în poziții de putere. '),
(3, 4, '     Practica înrobirii a fost justificată printr-un cumul de argumente ce țineau atât de spectrul religios 13 (deținătorii de sclavi asumându-și rolul de a creștina membrii popoarelor păgâne), cât și de cel moral și legislativ (populația crescândă a sclavilor, percepută ca inferioară celei majoritare, necesitând un control și o supraveghere strictă pentru o bună funcționare a societății) În acest fel, membrii  minorității au ajuns, gradual, să ocupe ultima poziție în ierarhia socială, statutul lor fiind puternic afectat de către o serie de legi care le-a restrâns treptat drepturile până în punctul în care sclavul afro-american și cel rom nu mai era în posesia deplină a propriului trup, a familiei sale, sau chiar a propriei vieți\n     Conform legii, o persoană înrobită era tratată ca proprietate și putea fi cumpărată, vândută sau dăruită. \n     In timpul  revoluției americane (1775–1783), statutul sclavilor era instituționalizat drept castă rasială ,asociată descendenței africane. În timpul Revoluției și imediat după, au fost adoptate legi abolitioniste⁠( în majoritatea statelor din  Nord⁠ și s-a dezvoltat o mișcare pentru abolirea sclaviei\n     Constituţia SUA nu menţionează direct instituţia sclaviei, dar face referiri indirecte în 3 puncte:· acordă Congresului dreptul de a interzice comerţul cu sclavi, după 20 de ani· într-o clauză prevăzută la articolul I, pune bazele dezbaterii cu  privire la numărarea sclavilor pentru a stabili taxele şi reprezentarea· articolul IV, secţiunea 2, face menţiune la o persoană ţinută într-un serviciu sau într-o muncă care fuge dintr-un stat şi se refugiază în altul. În cazul în care o parte solicita returnarea acelei persoane, cererea trebuie satisfăcută. Articolul IV, sectiunea 2 va determina în 1793 adoptarea Legii sclavilor fugari, care le dădea dreptul stăpânilor de sclavi să traverseze liniile de demarcaţie dintre state pentru a-şi recupera sclavii fugari. Conform acestei legii, dreptul de proprietate asupra unui presupus sclav fugar trebuia probat în instanţă. Ca reacţie, unele state din nord au adoptat legi care garantau libertăţi personale, acordându-le sclavilor fugari asistenţă juridică pentru a-şi putea susţine pledoaria.\n     Toate statele nordice au abolit în câte un fel sclavia până în 1805; uneori, desființarea a fost un proces treptat și sute de oameni au rămas înrobiți în statele din Nord până la recensămăntul  din 1840  Unii proprietari de sclavi  și-au eliberat⁠  sclavii, iar filantropii și organizațiile de caritate au cumpărat și eliberat alți sclavi\n     În aproximativ jumătate din statele SUA, sclavia a durat până în 1865. Ca sistem economic, sclavia a fost în mare parte înlocuită de arendă și închirierea deținuților.\n     Până în 1860, în Statele Unite existau patru milioane de sclavi și reprezentau o treime din populația din Sud. Dezacordurile cu privire la abolirea sau menținerea sclaviei au devenit atât de puternice încât 11 state s-au desprins din Statele Unite pentru a forma Confederația, care a dus la războiul civil. Confruntarea între Nord și Sud, a durat între 1861 și 1865..I n septembrie 1862, Proclamația de emancipare a lui Lincoln a transformat desființarea sclaviei din Sud într-un scop al războiului și i-a determinat pe britanici să nu intervină. După Războiul Civil, cu Uniunea victorioasă, al 13-lea amendament a fost adoptat în 1865. Această modificare a Constituției SUA a interzis oficial instituția formală a sclaviei.         În ciuda acestui triumf, foștii sclavi încă se confruntau cu multe obstacole. Aspectele sociale, politice, economice și rasiale ale războiului au marcat perioada de reconstrucție care a durat până în 1877 și au continuat să se manifeste și de-a lungul secolului al XX-lea. Persoanele de culoare au respins metodele coloniilor de muncă din perioada sclaviei; cu susținerea puternică a Biroului pentru Eliberați, ei au forțat proprietarii de plantații să negocieze contractele de muncă. Aceste negocieri au condus la înființarea sistemului arendei, care le-a dat negrilor o mai mare independență economică și socială decât coloniile de muncă. Totuși, din cauza lipsei de capital și deoarece proprietarii de plantații continuau să controleze mijloacele de producție (unelte, animale de povară și pământ), foștii sclavi au fost forțați să cultive plante industriale (mai ales bumbac) pentru proprietari și pentru negustori. Sărăcia pe scară largă, perturbarea unei economii predominant agrare puternic dependentă de bumbac, și prăbușirea prețului bumbacului, au condus în câteva decenii la îndatorarea majorității negrilor, și la sărăcirea multor proprietari de plantații.\n     Rasismul și inegalitatea politică și economică au dus la mișcarea drepturilor civile din anii 1960.'),
(4, 3, '     In America de Nord au ajuns peste 4 milioane de sclavi negri, doar în secolul al XVIII lea. Sclavii proveneau din rândul triburilor africane de pe coastele continentului şi mai rar din interiorul acestuia. Explicaţia este simplă, erau mai uşor de transporat până la vasele care-i aşteptau în porturi. De obicei existau grupuri de africani sau arabi specializaţi în vânătoarea de sclavi. Oamenii erau pur şi simplu răpiţi din sânul familiilor, puşi în lanţuri, obligaţi să mărşăluiască şi apoi vânduţi ca animalele în târguri. Erau preferaţi copii şi adulţii tineri.. Chiar şi americanii au avut propriile lor ”echipe” de vânători de sclavi. Odată îmbarcaţi, sclavii erau lăsaţi de multe ori în cale, fără aer, legaţi în lanţuri şi cu apă şi hrană insuficiente. Era un adevărat calvar, iar mulţi dintre aceştia mureau pe drum, din cauza bolilor sau a condiţiilor de transport. Ajunşi pe continetul American, erau vânduţi în târguri specializate marilor proprietari de plantaţii. \n     În secolele XVII şi XVIII sclavii erau folosiţi pe plantaţii de tutun, orez şi indigo în zona Maryland, Virginia şi Georgia. Majoritatea stăpânilor de sclavi aveau în jur de 10 africani, în timp ce marii proprietari deţineau şi câte 100-150 de sclavi. Evident sclavii nu aveau niciun drept. Erau adăpostiţi în grupuri, în barăci insalubre şi munceau până la epuizare. Primeau doar hrană. Majoritatea sclavilor erau încurajaţi să se căsătorească între ei, fiindcă se credea că aşa devneau mai docili şi, totodată, dădeau naştere altor sclavi. Viaţa acestora era însă ameninţată în permanenţă de violenţă sau separare, după cum dorea stăpânul. Înclusiv în secolul al XIX lea, când ţările civilizate ale Europei renunţaseră la sclavi, în Statele Unite, sclavia era în floare şi, mai mult decât atât, justificată de proprietarii de plantaţii. Odată cu răspândirea plantaţiilor de bumbac şi cererea extraordinară pe piaţa europeană, numărul sclavilor a crescut considerabil. \n     Marii stăpâni de sclavi doreau să obţină profit maxim cu cheltuieli minime pe mâna de lucru. Tocmai pentru a maximiza profitul şi pentru a obţine producţii rapide, Conform statutului sclavilor din Alabama din 1852, aceştia nu aveau voie să poarte arme, să depăşească limitele plantaţiei, să nu umble noaptea, să nu aibă câini şi să nu formeze grupuri mai mari de cinci persoane. are să aducă venituri mari şi la fel de rapide, erau folosiţi sclavii.'),
(5, 5, '     Mișcarea pentru drepturile civile a fost o luptă pentru justiție și egalitate pentru afro-americani, care a avut loc în principal în anii 1950 și 1960. Printre liderii săi s-au numărat Martin Luther King Jr., Malcolm X, Little Rock Nine, Rosa Parks și mulți alții.Războiul civil abolise oficial sclavia, dar nu a pus capăt discriminării împotriva oamenilor de culoare - au continuat să suporte efectele devastatoare ale rasismului, în special în sud.      \n     La mijlocul secolului al XX-lea, americanii negri avuseseră mai mult decât suficient prejudecăți și violență împotriva lor. Ei, alături de mulți americani albi, s-au mobilizat și au început o luptă fără precedent pentru egalitate care a durat două decenii.\n     Pe parcursul Reconstrucției Negrii au preluat roluri de conducere ca niciodată. Aceștia au deținut funcții publice și au căutat schimbări legislative pentru egalitate și dreptul la vot. entru a marginaliza oamenii negri, a-i menține separați de cei albi și a șterge progresul pe care îl făcuseră în timpul Reconstrucției, legile „Jim Crow” au fost stabilite în sud începând cu sfârșitul secolului al XIX-lea. Oamenii negri nu puteau folosi aceleași facilități publice ca oamenii albi, să locuiască în multe din aceleași orașe sau să meargă la aceleași școli. Căsătoria interrasială a fost ilegală, iar majoritatea oamenilor de culoare nu au putut vota deoarece nu au reușit să treacă testele de alfabetizare a alegătorilor. nainte de cel de-al doilea război mondial, majoritatea oamenilor negri lucrau ca fermieri cu salarii reduse, muncitori din fabrici, domestici sau servitori. \n     La începutul anilor 1940, munca legată de război era în plină expansiune, dar majoritatea americanilor negri nu primeau locuri de muncă mai bine plătite. De asemenea, au fost descurajați să se alăture armatei.\n     Bărbații și femeile negre au slujit eroic în cel de-al doilea război mondial, în ciuda suferinței de segregare și discriminare în timpul desfășurării lor. Tuskegee Airmen a rupt bariera rasială pentru a deveni primii aviatori militari negri din Corpul Aerian al Armatei SUA și a câștigat mai mult de 150 de distincții de zbor. Cu toate acestea, mulți veterani negri s-au confruntat cu prejudecăți și dispreț la întoarcerea acasă. Acesta a fost un puternic contrast cu motivul pentru care America a intrat în război pentru început - pentru a apăra libertatea și democrația în lume.\n     In 1954, mișcarea pentru drepturile civile a luat avânt când Curtea Supremă a Statelor Unite a făcut segregarea ilegală în școlile publice. În 1957, liceul central din Little Rock, Arkansas, a cerut voluntari de la liceele complet negre pentru a participa la școala fostă segregată.Treptat au fost adoptate si alte legi , precum cea a drepturilor civile din 1957, din 1964,legea dreptului de vot din 1965,legea privind o locuință echitabilă.'),
(8, 10, '     Martin Luther King Jr. (n. 15 ianuarie 1929, Atlanta, Georgia – d. 4 aprilie 1968, Memphis, Tennessee) a fost un pastor baptist nord-american, activist politic, cunoscut mai ales ca luptător pentru drepturile civile ale persoanelor de culoare din Statele Unite ale Americii.\n     Cunoscut și sub abrevierea MLK, a organizat și a condus marșuri în favoarea dreptului la vot, pentru desegregare rasială și alte drepturi civice elementare pentru cetățenii de culoare nord-americani. Cele mai multe astfel de legi, și anume Civil Rights Act, Voting Rights Act, au fost promulgate sub președinția lui Lyndon B. Johnson.\n     În timpul unui marș pentru libertate (28 august 1963) a pronunțat unul dintre cele mai celebre discursuri: I have a dream (Am un vis).\n     L-a cunoscut pe John Fitzgerald Kennedy care i-a acordat sprijinul în lupta împotriva discriminării rasiale.\n     Martin Luther King a fost cel mai tânăr laureat al Premiului Nobel pentru pace în 1964, pentru lupta împotriva segregației rasiale și discriminării rasiale. A depus eforturi în lupta împotriva sărăciei precum și a opririi războiului din Vietnam.\n     King a fost asasinat pe data de 4 aprilie 1968, în Memphis, Tennessee. După moartea sa i s-a acordat Medalia prezidențială pentru libertate în 1977 și Medalia de Aur în 2004; În 1986 ziua lui Martin Luther King a fost declarată zi federală în Statele Unite.\n\nMONTGOMERY:\n     În 1955, în Montgomery, Alabama, începe o campanie politică și socială împotriva segregării rasiale din transportul public, mai ales în autobuze, de unde și denumirea protestului-maraton, Montgomery Bus Boycott.\n     Protestul a fost declanșat de arestarea Rosei Parks, o americancă de culoare care a refuzat să cedeze locul unui alb în autobuz. Aceasta s-a întâmplat pe 1 decembrie 1955. Patru zile mai târziu, Rosa este condamnată la plata unei amenzi. Atunci intră în scena socială Martin Luther King (care până atunci era un pastor anonim), care, susținut și de Ralph Abernathy (1926 - 1990) lansează o campanie de protest care a durat 381 de zile. Perioada a fost foarte tensionată: King a fost arestat iar casa sa a fost bombardată cu represalii.\n     Pe 13 noiembrie 1956, Curtea Supremă este nevoită să declare ca neconstituționale legile de segregare din autobuzele publice din Montgomery.\n     Victoria a fost atât de răsunătoare, că, în 1957, King a fost ales lider al Southern Christian Leadership Conference. În același an, marele militant politic întreprinde mai multe călătorii în sudul SUA, unde ține peste 200 de cuvântări. Tot atunci scrie și prima sa carte, Stride Toward Freedom: The Montgomery Story. \n\nALBANY:\n     În data de 17 noiembrie 1961, o coaliție formată din activiști locali ai organizației locale a NAACP (National Association for the Advancement of Colored People) și ai SNCC (Student Nonviolent Coordinating Committee), în orașul Albany din statul Georgia, a decis declanșarea unei campanii de proteste non-violente contra segregației și discriminării rasiale, prin ocuparea și boicotarea stațiilor de autobuz, magazinelor și localurilor destinate exclusiv albilor și prin marșuri de protest prin fața primăriei orașului. Martin Luther King, sosit în oraș în 14 decembrie 1961, va fi arestat a doua zi în timp ce participa la un marș de protest. Deși refuzase să fie eliberat pe cauțiune până când autoritățile nu vor satisface cererile protestatarilor, va fi eliberat totuși, și se va întoarce în oraș în iulie 1962. Arestat din nou, va fi condamnat la 45 de zile de închisoare sau plata unei amenzi de 178$. Martin Luther King a ales închisoarea. După trei zile, șeful poliției locale, Laurie Pritchett, a aranjat discret plata cauțiunii și eliberarea acestuia. De altfel, tactica autorităților a fost de a opera arestări în masă sub pretextul asigurării liniștii publice, dispersarea arestaților în centre de detenție îndepărtate, urmate de eliberarea discretă a acestora, fără a face vreo concesie, astfel încât până la urmă, mișcarea de protest nu și-a atins scopurile. Martin Luther King va fi din nou arestat spre sfârșitul lunii iulie, fiind reținut două săptămâni, după care va părăsi definitiv orașul, fără a obține prea mari concesii din partea autorităților.\n\nBIRMINGHAM:\n     Cu circa 350 000 de locuitori, din care populația de culoare reprezenta aproape 40%, în 1960, orașul Birmingham din statul Alabama era unul din cele mai segregate rasial orașe din Statele Unite. După eșecul campaniei din Albany, Martin Luther King a decis să schimbe tactica, încercând să deplaseze presiunile asupra autorităților înspre factorii economici. S-a urmărit ca prin proteste pașnice și prin boicotarea comerțului și serviciilor, să se provoace arestări în masă, care să conducă la paralizarea activității economice. Campania de proteste era cât pe ce să eșueze în momentul în care șeful poliției locale, Eugene “Bull” Connor, a obținut o derogare de la lege, ceea ce i-a permis să ridice valoarea cauțiunii de la 300$ la 1200$ (cca. 9000$ în 2014), o sumă destul de mare pe atunci, ceea ce a condus la demoralizarea multora din protestatari. În plus, a ridicat noi probleme pentru Martin Luther King, nevoit să colecteze sume extrem de ridicate de bani de la populația de culoare din restul SUA. La toate aceste probleme s-a adăugat și arestarea acestuia în 12 aprilie 1963, a 13-a, pe când încerca să mobilizeze populația de culoare descurajată de măsurile represive luate de autorități. În închisoare, Martin Luther King a scris pe marginea unui ziar celebra “Letter from Birmingham Jail”. (16 aprilie 1963) Un lider local, James Bevel, a încercat să depășească impasul în care se găsea deja mișcarea de protest, prin mobilizarea elevilor de culoare, numită Cruciada Copiilor în revista Newsweek. De această dată protestele nu au mai fost atât de pașnice, ceea ce atras riposta dură a poliției, care a utilizat tunuri de apă și câini polițiști pentru împrăștierea manifestanților. Imaginile transmise în direct de marile canale de televiziune au impresionat întreaga națiune, consolidând poziția lui Martin Luther King și a mișcării pentru drepturile civile ale populației de culoare. Totodată, mulți au criticat folosirea copiilor în scopuri politice. Protestele populației de culoare, paralizarea activității economice a orașului și atenția întregii națiuni, au determinat autoritățile din Birmingham să se așeze la masa negocierilor. Acceptate de oficialități, revendicările populației de culoare au fost îndeplinite treptat de-abia în deceniul următor.\n\nMITINGUL DE LA WASHINGTON:\n     Martin Luther King împreună cu SCLC (Southern Christian Leadership Conference), s-a numărat printre liderii așa-numitei organizații pentru drepturile civile ale populației de culoare \"Big Six\", care a organizat Marșul spre Washington, care a avut loc în 28 august 1963. Protestatarii au avut revendicări extrem de precise: încetarea segregației rasiale în școlile publice, legi care să interzică discriminarea rasială la angajare, protecția liderilor populației de culoare față de brutalitățile poliției, salariul minim orar de 2$. În ciuda dezacordurilor dintre lideri, marșul a fost un succes, cu peste un sfert de milion de participanți, unul din cele mai impresionante mișcări de protest din epocă. Participanții s-au oprit în fața memorialului Lincoln din Washington DC.\n     Cu această ocazie, Martin Luther King a ținut un discurs cu durata de cca. 17 min., cunoscut ulterior sub numele de \"I Have a Dream\" (Am un vis), discurs ce va deveni celebru. Partea cea mai cunoscută și mai citată, în care King se detașează oarecum de textul original pregătit anterior, se datorează probabil Mahaliei Jackson, care i-ar fi șoptit la ureche: \"vorbește-le despre vis\". King a spus atunci, citez:    \n\"Vă spun azi, prieteni - chiar dacă va trebui să dăm piept cu greutățile de azi și de mâine, că am avut un vis. Este un vis cu rădăcini adânci în visul american. Am visat că într-o zi, această națiune se va ridica și va înțelege adevărul cuprins în crezul său: susținem că acesta este evident - toți oamenii se nasc egali. Am visat că într-o zi, pe dealurile roșii din Georgia, copiii foștilor sclavi vor sta la aceeași masă cu copiii foștilor proprietari de sclavi. Am visat ca într-o zi, statul Mississippi însuși, stat în care te gâtuie injustiția, stat în care te gâtuie oprimarea, să se transforme într-o oază de libertate și justiție. Am visat că cei patru copii ai mei vor trăi într-o zi în mijlocul unei națiuni în care nu vor mai fi judecați după culoarea pielii, ci după calitățile lor.\"\n     \"I Have a Dream\" este considerat astăzi unul din cele mai bune discursuri din istoria Americii. Marșul ce a urmat, dar în special discursul emoționant al lui King, au contribuit din plin la promulgarea Civil Rights Act în 1964.\n\nPREMIUL NOBEL:\n     În semn de recunoaștere a întregii sale activități în slujba populației de culoare, pentru combaterea discriminării rasiale prin proteste pașnice, în 14 octombrie 1964, Martin Luther King a primit premiul Nobel pentru pace, devenind cel mai tânăr laureat al acestuia. În discursul rostit cu această ocazie, l-a menționat pe Gandhi în calitate de pionier al luptei cu mijloace pașnice contra inechităților sociale. De altfel, l-a avut pe Gandhi drept model de-a lungul întregii sale vieți, și se pare că exemplul acestuia i-a inspirat anumite principii morale.\n\nDUMINICA SANGEROASA\n     Marșul de protest de la Selma la Montgomery din 1965, cunoscut și sub numele de Duminica Sângeroasă (Bloody Sunday), ca și cele alte două marșuri de protest care i-au urmat, au constituit apogeul luptei populației de culoare din Statele Unite pentru drepturile civile. Selma era unul din orașele principale ale ținutului Dallas din statul Alabama, în care populația de culoare, în proporție de 57%, era practic lipsită de dreptul de vot. Din 15 000 de locuitori de culoare ce aveau deja vârsta legală pentru a putea vota, doar 130 erau înregistrați. În același timp, 80% din populația de culoare a orașului trăia sub pragul de sărăcie, marea majoritate lucrând ca muncitori zilieri în agricultură. Mișcarea a început în 1963 prin înscrierea cetățenilor de culoare pe listele electorale, acțiune coordonată de o organizație locală, Dallas County Voters League (DCVL). În momentul în care acțiunea a întâmpinat rezistență din partea autorităților locale, prin impunerea de teste de scris și citit, prin presiuni și amenințări, DCVL a cerut sprijinul lui Martin Luther King. Mișcarea de protest a debutat oficial în data de 2 ianuarie 1965, atunci când King s-a adresat participanților la un mare miting organizat în Brown Chapel. Primul marș de protest a avut loc în 7 martie 1965 (Bloody Sunday), având 600 de participanți, pentru a protesta contra excluderii cetățenilor de culoare din cadrul procesului electoral. Manifestanții au fost atacați și dispersați de forțele de poliție care au utilizat bastoane și gaze lacrimogene. Al doilea marș (Turnaround Tuesday), având 2500 de participanți, a avut loc în data de 9 martie 1965. Și de această dată protestatarii au fost opriți și întorși din drum de către forțele de poliție. Marșurile aveau ca destinație finală clădirea Capitoliului din Montgomery, protestatarii dorind să discute cu guvernatorul George Wallace despre încălcarea drepturilor civile ale populației de culoare. Intervenția brutală a forțelor de poliție a fost transmisă de principalele canale de televiziune, mulți americani fiind oripilați de violența cu care a fost reprimată demonstrația pașnică din 7 martie. Fotografia uneia din participante, Amelia Boynton, plină de sânge, a apărut pe prima pagină a presei, făcând înconjurul lumii. Al treilea marș și ultimul va fi organizat în 16 martie 1965. De data aceasta, pentru a evita orice incident, protestatarii au fost protejați de un impresionant dispozitiv format din 1900 militari ai Gărzii Naționale, 2000 de soldați ai U.S. Army, agenți federali și ai FBI. Participanții au mărșăluit pe o distanță de 10 mile (16 km) de-a lungul autostrăzii Jefferson Davis (US Route 80), sosind în Montgomey pe 24, pentru ca în 25 să se oprească în fața Capitoliului. Din cei 8000 de participanți care plecaseră din Selma, doar 300 vor ajunge în Montgomery, majoritatea renunțând pe parcurs. În 25 însă, alți protestatari se vor întoarce cu autobuze sau automobile proprii, astfel că numărul celor strânși se va ridica la 25 000 de persoane. Aici, Martin Luther King va rosti discursul \"How Long, Not Long.\" După aceasta, King și mulțimea din jurul său se vor îndrepta spre intrarea în clădire pentru a înmâna o petiție guvernatorului George Wallace. În lipsa acestuia, petiția a fost înmânată unuia din secretari. Cele trei marșuri de protest au avut un serios impact la Washington. Președintele în exercițiu, Lyndon B. Johnson s-a întâlnit cu George Wallace pentru a discuta situația drepturilor civile ale populației de culoare în Alabama. Două zile mai târziu, în 15 martie 1965, președintele avea să prezinte un proiect de lege în sesiunea comună a Congresului. Legea va fi votată ulterior, devenind Voting Rights Act.\n\nCHICAGO:\n     Mișcarea de Eliberare din Chicago (Chicago Freedom Movement, cunoscută și sub numele de Chicago Open Housing Movement) a fost o mișcare de protest inițiată și condusă de Martin Luther King, împreună cu Al Raby. Mișcarea a constat în marșuri de protest și petiții adresate municipalității orașului Chicago. Cererile protestatarilor aveau un evantai foarte larg, cuprinzând condițiile de locuit, accesul la educație și la sistemul de sănătate, locuri de muncă, calitatea actului de justiție, dezvoltarea comunitară și calitatea vieții. Prin multitudinea de obiective propuse, a constituit cea mai ambițioasă mișcare de protest a populației de culoare din nordul Statelor Unite. Mișcarea a rezultat din alianța dintre Southern Christian Leadership Conference (SCLC), condusă de King, și o organizație locală, Coordinating Council of Community Organizations (CCCO). Principalul obiectiv al mișcării a fost eliminarea discriminării în ceea ce privește condițiile de locuit. Apogeul a fost atins în data de 10 iulie 1966, cu ocazia unui miting organizat de către Martin Luther King în Soldier Field, la care s-au strâns cca. 35000 de persoane, fiind invitate și vedete de culoare, printre care Mahalia Jackson și Stevie Wonder. Mișcarea a continuat cu marșuri de protest organizate prin cartierele locuite de albi ale orașului Chicago, din zona de sud-vest și nord-vest a orașului. Aceste proteste au provocat adesea reacții violente din partea albilor, care au alarmat primăria, atrăgând și atenția mass-media. În 10 iulie 1966, Martin Luther King a pus o listă cu revendicările populației de culoare pe ușa primăriei orașului Chicago.  În consecință, o lună mai târziu au început negocieri între reprezentanții protestatarilor, primărie, și factorii de răspundere din domeniul imobiliar (Chicago Real Estate Board), ajungându-se la o înțelegere (Summit Agreement) în data de 26 august 1966. Odată ce obiectivele principale au fost atinse, Martin Luther King și SCLC au decis să-și concentreze energiile în alte direcții, punând capăt acestei campanii.\n\nRĂZBOIUL DIN VIETNAM:\n     Începând cu 1965, Martin Luther King a început să se pronunțe tot mai des în public contra escaladării conflictului armat din Vietnam. În 4 aprilie 1967, exact cu un an înainte să fie asasinat, în cadrul unei apariții publice la biserica Riverside din New York, King a ținut un discurs intitulat \"Beyond Vietnam: A Time to Break Silence\". În cadrul acestui discurs a condamnat politica americană în Vietnam, \"ocupat ca o colonie americană\". King se opunea războiului mai ales din rațiuni economice, susținând că acesta consuma resurse care ar fi putut foarte bine fi folosite acasă, pentru combaterea sărăciei populației de culoare, dar și din considerente umanitare, susținând că armata americană ar fi omorât deja un milion de vietnamezi, în mare parte copii. Toate aceste luări de poziție publice au cauzat retragerea sprijinului de care se bucura printre susținătorii albi, în principal al președintelui Lyndon B. Johnson, al liderilor de sindicat și al formatorilor de opinie din mass-media. Discursul \"Beyond Vietnam\" reflectă evoluția ideilor politice ale lui King în ultima perioadă a vieții sale. El vorbea despre necesitatea unor schimbări fundamentale în viața politică și economică a națiunii, pronunțându-se pentru o redistribuire mai echitabilă a resurselor, pentru a corecta inechitățile rasiale și sociale. În public, și-a controlat cu grijă modul de exprimare pentru a nu fi acuzat de idei comuniste, dar în particular și-a manifestat totdeauna interesul pentru socialism. King îl citise deja pe Marx, dar respingea totuși comunismul datorită ateismului declarat și totalitarismului politic al acestuia. În 15 aprilie 1967, Martin Luther King a participat și a ținut și un discurs la un marș contra războiului din Vietnam organizat în Central Park din New York. În 13 ianuarie 1968, King a făcut apel pentru un marș la Washington, contra la ce el numea \"unul din cele mai crude și mai absurde războaie\", pronunțându-se pentru auto-determinarea popoarelor din Asia de sud-est.');

-- --------------------------------------------------------

--
-- Table structure for table `continut_teste`
--

CREATE TABLE `continut_teste` (
  `id` int(11) NOT NULL,
  `idTest` int(11) NOT NULL,
  `idIntrebare` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `continut_teste`
--

INSERT INTO `continut_teste` (`id`, `idTest`, `idIntrebare`) VALUES
(1, 1, 2),
(2, 1, 9),
(3, 1, 4),
(4, 1, 8),
(5, 1, 10),
(6, 1, 5),
(7, 1, 6),
(8, 1, 3),
(9, 1, 7),
(10, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `conturi`
--

CREATE TABLE `conturi` (
  `id` int(11) NOT NULL,
  `utilizator` text NOT NULL,
  `email` text NOT NULL,
  `parola` text NOT NULL,
  `drepturi` text NOT NULL,
  `ultimaLogare` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `conturi`
--

INSERT INTO `conturi` (`id`, `utilizator`, `email`, `parola`, `drepturi`, `ultimaLogare`) VALUES
(1, 'Pop Anca', 'popanca@gmail.com', 'popANCA00', 'profesor', '2023-05-17'),
(2, 'Negru Diana', 'diana.negru@yahoo.com', 'DianaNegru', 'elev', '2023-05-03'),
(3, 'Muresan Iustin', 'iustin.muresan@yahoo.com', 'MuresanIustin', 'elev', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `imagini`
--

CREATE TABLE `imagini` (
  `idImg` int(11) NOT NULL,
  `idL` int(11) NOT NULL,
  `denumire` text NOT NULL,
  `cale` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `imagini`
--

INSERT INTO `imagini` (`idImg`, `idL`, `denumire`, `cale`) VALUES
(2, 2, 'Mișcarea aboliționistă', 'Img/miscarea_abolitionista.jpg'),
(3, 2, 'Sclavi care lucrau pe plantații', 'Img/plantatie_sclavi.jpg'),
(4, 2, 'Comerțul cu sclavi', 'Img/Comertul_cu_sclavi.jpg'),
(5, 4, 'Reclamă pentru comerțul cu sclavi', 'Img/Reclama_pentru_comertul_cu_sclavi.jpg'),
(6, 4, 'Comerțul cu sclavi afro-americani', 'Img/Comertul_cu_sclavi.jpg'),
(7, 4, 'al 13-lea Amandament', 'Img/al_13-lea_amandament.jpg'),
(8, 4, 'Proclamația de emancipare', 'Img/proclamatia_de_emancipare.jpg'),
(9, 3, 'Sclavi care lucrează pe plantații', 'Img/plantatie_sclavi.jpg'),
(16, 5, 'Martin Luther King Jr.', 'Img/Martin_Luther_King_Jr.jpg'),
(17, 5, 'Malcom X', 'Img/Malcom_X.jpg'),
(18, 5, 'Little Rock Nine', 'Img/Little_Rock_Nine.jpg'),
(19, 5, 'Rosa Parks', 'Img/Rosa_Parks.jpg'),
(20, 5, 'Tuskegee Airmen', 'Img/Tuskegee_Airmen.jpg'),
(24, 10, 'Martin Luther King Jr.', 'Img/Martin_Luther_King_Jr.jpg'),
(25, 10, 'Rosa Parks cu Martin Luther King în fundal', 'Img/Rosa_Parks.jpg'),
(26, 10, 'Întâlnirea cu organizatorii Marșului de la Washington (1963)', 'Img/Intalnirea_cu_organizatorii_Marsului_de_la_Washington_1963.jpg'),
(27, 10, 'Martin Luther King Jr. si protestatarii de la marșul Selma-Montgomery (1965)', 'Img/Martin_Luther_King_Jr._si_protestatarii_la_marsul_Selma-Montgomery_1965.JPG');

-- --------------------------------------------------------

--
-- Table structure for table `intrebari`
--

CREATE TABLE `intrebari` (
  `idIntrebare` int(11) NOT NULL,
  `idProfesor` int(11) NOT NULL,
  `intrebare` text NOT NULL,
  `capitol` text NOT NULL,
  `lectie` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `intrebari`
--

INSERT INTO `intrebari` (`idIntrebare`, `idProfesor`, `intrebare`, `capitol`, `lectie`) VALUES
(1, 1, 'Scieți termenul la care se refera definiția: “desemnează condiția umană a persoanelor care lucrează pentru un stăpân fără remunerație și ce nu dispun de drepturi asupra propriei persoane”.', 'Începuturile', 'Începuturile sclaviei'),
(2, 1, 'Pe ce fel de plantații lucrau sclavii?', 'Sclavul și sclavia', 'Viața sclavilor'),
(3, 1, 'Ce doreau să obțină marii stăpâni de sclavi?', 'Sclavul și sclavia', 'Viața sclavilor'),
(4, 1, 'Între ce ani a avut loc Revoluția Americană?', 'Sclavul și sclavia', 'Statutul sclavilor'),
(5, 1, 'În ce an a fost adoptat al 13-lea Amandament?', 'Sclavul și sclavia', 'Statutul sclavilor'),
(6, 1, 'Ce a dus la mișcarea drepturilor civile?', 'Sclavul și sclavia', 'Statutul sclavilor'),
(7, 1, 'Cine a susținut emanciparea?', 'Sclavul și sclavia', 'Statutul sclavilor'),
(8, 1, 'Prin adoptarea celul de al 13-lea Amandament s-a interzis oficial:', 'Sclavul și sclavia', 'Statutul sclavilor'),
(9, 1, 'Ce a reprezentat “Mișcarea pentru drepturile civile”?', 'Emanciparea', 'Mișcarea pentru drepturile civile'),
(10, 1, 'Când au fost stabilite legile “Jim Crow”?', 'Emanciparea', 'Mișcarea pentru drepturile civile');

-- --------------------------------------------------------

--
-- Table structure for table `lectii`
--

CREATE TABLE `lectii` (
  `idL` int(11) NOT NULL,
  `idC` int(11) NOT NULL,
  `Titlu` text NOT NULL,
  `idProfesor` int(11) NOT NULL,
  `data_adaugare` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lectii`
--

INSERT INTO `lectii` (`idL`, `idC`, `Titlu`, `idProfesor`, `data_adaugare`) VALUES
(3, 2, 'Viața sclavilor', 1, '2023-05-02'),
(4, 2, 'Statutul sclavilor', 1, '2023-05-02'),
(5, 3, 'Mișcarea pentru drepturile civile', 1, '2023-05-02'),
(1, 1, 'Explorarea Africii', 1, '2023-04-19'),
(2, 1, 'Începuturile sclaviei', 1, '2023-05-02'),
(10, 4, 'Martin Luther King', 1, '2023-05-13');

-- --------------------------------------------------------

--
-- Table structure for table `notificari`
--

CREATE TABLE `notificari` (
  `id` int(11) NOT NULL,
  `idCont` int(11) NOT NULL,
  `tipNotificare` text NOT NULL,
  `idLectie` int(11) NOT NULL,
  `idTest` int(11) NOT NULL,
  `idIntrebare` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `notificari`
--

INSERT INTO `notificari` (`id`, `idCont`, `tipNotificare`, `idLectie`, `idTest`, `idIntrebare`) VALUES
(8, 1, 'modifLectie', 3, 0, 0),
(11, 1, 'modifLectie', 3, 0, 0),
(12, 1, 'modifLectie', 3, 0, 0),
(13, 1, 'adaugareLectie', 4, 0, 0),
(14, 1, 'adaugareLectie', 5, 0, 0),
(15, 1, 'modifLectie', 3, 0, 0),
(16, 1, 'modifLectie', 5, 0, 0),
(17, 1, 'modifLectie', 5, 0, 0),
(18, 1, 'adaugaIntrebare', 0, 0, 1),
(19, 1, 'adaugaIntrebare', 0, 0, 2),
(20, 1, 'modifIntrebare', 0, 0, 2),
(21, 1, 'adaugaIntrebare', 0, 0, 3),
(22, 1, 'adaugaIntrebare', 0, 0, 4),
(23, 1, 'adaugaIntrebare', 0, 0, 5),
(24, 1, 'adaugaIntrebare', 0, 0, 6),
(25, 1, 'adaugaIntrebare', 0, 0, 7),
(26, 1, 'adaugaIntrebare', 0, 0, 8),
(27, 1, 'adaugaIntrebare', 0, 0, 9),
(28, 1, 'adaugaIntrebare', 0, 0, 10),
(29, 1, 'adaugareTest', 0, 1, 0),
(30, 1, 'modifLectie', 5, 0, 0),
(31, 2, 'modifLectie', 5, 0, 0),
(32, 1, 'adaugareLectie', 6, 0, 0),
(33, 2, 'adaugareLectie', 6, 0, 0),
(34, 1, 'modifLectie', 6, 0, 0),
(35, 2, 'modifLectie', 6, 0, 0),
(36, 1, 'adaugareLectie', 8, 0, 0),
(37, 2, 'adaugareLectie', 8, 0, 0),
(38, 3, 'adaugareLectie', 8, 0, 0),
(39, 1, 'modifLectie', 8, 0, 0),
(40, 2, 'modifLectie', 8, 0, 0),
(41, 3, 'modifLectie', 8, 0, 0),
(42, 1, 'adaugareLectie', 10, 0, 0),
(43, 2, 'adaugareLectie', 10, 0, 0),
(44, 3, 'adaugareLectie', 10, 0, 0),
(45, 1, 'modifLectie', 1, 0, 0),
(46, 2, 'modifLectie', 1, 0, 0),
(47, 3, 'modifLectie', 1, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `raspunsuri`
--

CREATE TABLE `raspunsuri` (
  `idRaspuns` int(11) NOT NULL,
  `idIntrebare` int(11) NOT NULL,
  `raspuns` text NOT NULL,
  `tipRaspuns` text NOT NULL,
  `corect` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `raspunsuri`
--

INSERT INTO `raspunsuri` (`idRaspuns`, `idIntrebare`, `raspuns`, `tipRaspuns`, `corect`) VALUES
(1, 1, 'sclavia', 'text scurt', 'da'),
(2, 2, 'tutun', 'multiplu', 'da'),
(3, 2, 'orez', 'multiplu', 'da'),
(4, 2, 'bumbac', 'multiplu', 'da'),
(5, 3, 'profit maxim cu cheltuieli minime pe mâna de lucru', 'unic', 'da'),
(6, 3, 'profit minim cu cheltuieli mari pe mâna de lucru', 'unic', 'nu'),
(7, 3, 'profit maxim cu cheltuieli mari pe mâna de lucru', 'unic', 'nu'),
(8, 4, '1775-1783', 'text scurt', 'da'),
(9, 5, '1865', 'text scurt', 'da'),
(10, 6, 'rasismul', 'multiplu', 'da'),
(11, 6, 'egalitatea dintre indivizi', 'multiplu', 'nu'),
(12, 6, 'inegalitatea politică și economică', 'multiplu', 'da'),
(13, 7, 'proprietarii de sclavi', 'unic', 'nu'),
(14, 7, 'Lincoln ', 'unic', 'da'),
(15, 7, 'cei care făceau comerț cu sclavi', 'unic', 'nu'),
(16, 8, 'dreptul la vot al sclavilor', 'unic', 'nu'),
(17, 8, 'dreptul la muncă', 'unic', 'nu'),
(18, 8, 'instituția formală a sclaviei', 'unic', 'da'),
(19, 9, 'o luptă pentru pierderea drepturilor pe care le au sclavii', 'multiplu', 'nu'),
(20, 9, 'o luptă pentru justiție ', 'multiplu', 'da'),
(21, 9, 'o luptă pentru egalitate ', 'multiplu', 'da'),
(22, 10, 'la sfârșitulsecolului XVIII', 'unic', 'nu'),
(23, 10, 'la începutul secolului XX', 'unic', 'nu'),
(24, 10, 'la sfârșitul secolului XIX', 'unic', 'da');

-- --------------------------------------------------------

--
-- Table structure for table `teste`
--

CREATE TABLE `teste` (
  `idTest` int(11) NOT NULL,
  `denumire` text NOT NULL,
  `idProfesor` int(11) NOT NULL,
  `data_adaugare` date NOT NULL,
  `capitol` text NOT NULL,
  `lectie` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `teste`
--

INSERT INTO `teste` (`idTest`, `denumire`, `idProfesor`, `data_adaugare`, `capitol`, `lectie`) VALUES
(1, 'Testul 1', 1, '0000-00-00', 'General', 'General');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `capitole`
--
ALTER TABLE `capitole`
  ADD PRIMARY KEY (`idC`);

--
-- Indexes for table `continut_lectii`
--
ALTER TABLE `continut_lectii`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idL` (`idL`);

--
-- Indexes for table `continut_teste`
--
ALTER TABLE `continut_teste`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idTest` (`idTest`);

--
-- Indexes for table `conturi`
--
ALTER TABLE `conturi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `imagini`
--
ALTER TABLE `imagini`
  ADD PRIMARY KEY (`idImg`),
  ADD KEY `idL` (`idL`);

--
-- Indexes for table `intrebari`
--
ALTER TABLE `intrebari`
  ADD PRIMARY KEY (`idIntrebare`),
  ADD KEY `idProfesor` (`idProfesor`);

--
-- Indexes for table `lectii`
--
ALTER TABLE `lectii`
  ADD KEY `idC` (`idC`),
  ADD KEY `idL` (`idL`) USING BTREE;

--
-- Indexes for table `notificari`
--
ALTER TABLE `notificari`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `raspunsuri`
--
ALTER TABLE `raspunsuri`
  ADD PRIMARY KEY (`idRaspuns`),
  ADD KEY `idIntrebare` (`idIntrebare`);

--
-- Indexes for table `teste`
--
ALTER TABLE `teste`
  ADD PRIMARY KEY (`idTest`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `capitole`
--
ALTER TABLE `capitole`
  MODIFY `idC` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `continut_lectii`
--
ALTER TABLE `continut_lectii`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `continut_teste`
--
ALTER TABLE `continut_teste`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `conturi`
--
ALTER TABLE `conturi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `imagini`
--
ALTER TABLE `imagini`
  MODIFY `idImg` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `intrebari`
--
ALTER TABLE `intrebari`
  MODIFY `idIntrebare` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `lectii`
--
ALTER TABLE `lectii`
  MODIFY `idL` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `notificari`
--
ALTER TABLE `notificari`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT for table `raspunsuri`
--
ALTER TABLE `raspunsuri`
  MODIFY `idRaspuns` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `teste`
--
ALTER TABLE `teste`
  MODIFY `idTest` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
