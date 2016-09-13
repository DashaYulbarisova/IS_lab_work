;;****************
;;* DEFFUNCTIONS *
;;****************

(deffunction ask-question (?question $?allowed-values)
   (printout t ?question)
   (bind ?answer (read))
   (if (lexemep ?answer)
       then (bind ?answer (lowcase ?answer)))
   (while (not (member ?answer ?allowed-values)) do
      (printout t ?question)
      (bind ?answer (read))
      (if (lexemep ?answer)
          then (bind ?answer (lowcase ?answer))))
   ?answer)

(deffunction yes-or-no-p (?question)
   (bind ?response (ask-question ?question yes no y n))
   (if (or (eq ?response yes) (eq ?response y))
       then yes
       else no))

;;;***************
;;;* QUERY RULES *
;;;***************

(defrule determine-goal-book ""
   (not (road-book ?))
   (not (advice ?))
   =>
   (assert (road-book (yes-or-no-p "Do you want to read a book on the road (yes/no)? "))))

(defrule determine-classic-book ""
   (road-book yes)
   (not (advice ?))
   =>
   (assert (classic-book (yes-or-no-p "Do you want to read a classic book (yes/no)? "))))

(defrule determine-novel ""
   (road-book no)
   (not (advice ?))
   =>
   (assert (novel (yes-or-no-p "Do you want to read a novel (yes/no)? "))))

(defrule determine-russian-book2 ""
   (novel no)
   (not (advice ?))
   =>
   (assert (russian-book2 (yes-or-no-p "Do you want to read a book written by Russian (yes/no)? "))))

(defrule determine-classic-book2 ""
   (russian-book2  yes)
   (not (advice ?))
   =>
   (assert (classic-book2 (yes-or-no-p "Do you want to read a classic book (yes/no)? "))))

(defrule determine-philosophy ""
   (russian-book2 no)
   (not (advice ?))
   =>
   (assert (philosophy (yes-or-no-p "Do you want to read a philosophical book (yes/no)? "))))

(defrule determine-science ""
   (russian-book2 no)
   (not (advice ?))
   =>
   (assert (science (yes-or-no-p "Do you want to read a scientific and popular book (yes/no)? "))))

(defrule determine-russian-book ""
    (classic-book yes)
    (not (advice ?))
    =>
    (assert (russian-book (yes-or-no-p "Do you want to read a book written by Russian (yes/no)? "))))

(defrule determine-book-about-nature ""
   (russian-book yes)
   (not (advice ?))
   =>
   (assert (book-about-nature (yes-or-no-p "Do you want to read a book about nature (yes/no)? "))))

(defrule determine-book-about-relationship ""
   (book-about-nature no)
   (not (advice ?))
   =>
   (assert (book-about-relationship (yes-or-no-p "Do you want to read a book about relationship (yes/no)? "))))

(defrule determine-detective ""
   (russian-book no)
   (not (advice ?))
   =>
   (assert (detective (yes-or-no-p "Do you want to read a detective (yes/no)? "))))

(defrule determine-love-story ""
   (russian-book no)
   (not (advice ?))
   =>
   (assert (love-story (yes-or-no-p "Do you want to read a love-story (yes/no)? "))))

(defrule determine-thriller ""
   (classic-book no)
   (not (advice ?))
   =>
   (assert (thriller (yes-or-no-p "Do you want to read a thriller (yes/no)? "))))

(defrule determine-love-story2 ""
   (classic-book no)
   (not (advice ?))
   =>
   (assert (love-story2 (yes-or-no-p "Do you want to read a love story (yes/no)? "))))

(defrule determine-satire ""
   (classic-book no)
   (not (advice ?))
   =>
   (assert (satire (yes-or-no-p "Do you want to read a satire (yes/no)? "))))

(defrule determine-century ""
    (novel yes)
    (not (advice ?))
    =>
    (printout t "ABCDEF? ")
    (bind ?c (read))
    (if (< ?c 19) then (assert (century first))
    else (if (= ?c 19) then (assert (century second))
          else (assert (century third)))))

(defrule determine-russian-book3 ""
    (century second)
    (not (advice ?))
    =>
    (assert (russian-book3 (yes-or-no-p "Do you want to read a book written by Russian (yes/no)? "))))

(defrule determine-fantasy ""
    (century third)
    (not (advice ?))
    =>
    (assert (fantasy (yes-or-no-p "Do you want to read a fantasy book (yes/no)? "))))

;;;****************
;;;* REPAIR RULES *
;;;****************

(defrule advice-book-about-nature ""
   (book-about-nature yes)
   (not (advice ?))
   =>
   (assert (advice "Read Prishvin, Turgenev.")))

(defrule advice-book-about-relationship-y ""
   (book-about-relationship yes)
   (not (advice ?))
   =>
   (assert (advice "Read Lermontov, Pushkin.")))

(defrule advice-book-about-relationship-n ""
   (book-about-relationship no)
   (not (advice ?))
   =>
   (assert (advice "Read fables, poems.")))

(defrule advice-detective ""
    (detective yes)
    (not (advice ?))
    =>
    (assert (advice "Read Agatha Christie.")))

(defrule advice-love-story-y ""
   (love-story yes)
   (not (advice ?))
   =>
   (assert (advice "Read Jane Austen.")))

(defrule advice-love-story-n ""
   (love-story no)
   (not (advice ?))
   =>
   (assert (advice "Read O.Henry.")))

(defrule advice-thriller ""
   (thriller yes)
   (not (advice ?))
   =>
   (assert (advice "Read Paul Hawkins, Stephen King.")))

(defrule advice-love-story2 ""
   (love-story2 yes)
   (not (advice ?))
   =>
   (assert (advice "Read Jojo Moyes, John Green.")))

(defrule advice-satire-y ""
   (satire yes)
   (not (advice ?))
   =>
   (assert (advice "Read Chuck Palahniuk.")))

(defrule advice-satire-n ""
   (satire no)
   (not (advice ?))
   =>
   (assert (advice "Read comics.")))

(defrule advice-classic-book2-y ""
   (classic-book2 yes)
   (not (advice ?))
   =>
   (assert (advice "Read Dostoevsky, Bulgakov.")))

(defrule advice-classic-book2-n ""
   (classic-book2 no)
   (not (advice ?))
   =>
   (assert (advice "Read Ivanov, Dovlatov and Sanaev.")))

(defrule advice-philosophy ""
   (philosophy yes)
   (not (advice ?))
   =>
   (assert (advice "Read Kafka, Sartre, Nietzsche.")))

(defrule advice-science-y ""
   (science yes)
   (not (advice ?))
   =>
   (assert (advice "Read Asya Kazantsev, Stephen Hawking.")))

(defrule advice-science-n ""
   (science no)
   (not (advice ?))
   =>
   (assert (advice "Read biography.")))

(defrule advice-centuryfirst ""
   (century first)
   (not (advice ?))
   =>
   (assert (advice "XVIII century")))

(defrule advice-fantasy-y ""
    (fantasy yes)
    (not (advice ?))
    =>
    (assert (advice "FANTASY YES")))

(defrule advice-fantasy-n ""
    (fantasy no)
    (not (advice ?))
    =>
    (assert (advice "FANTASY NO")))

(defrule advice-russian3-y ""
    (russian-book3 yes)
    (not (advice ?))
    =>
    (assert (advice "RUS BOOK 3 YES")))

(defrule advice-russian3-n ""
    (russian-book3 no)
    (not (advice ?))
    =>
    (assert (advice "RUS BOOK 3 NO")))

(defrule system-banner ""
  (declare (salience 10))
  =>
  (printout t crlf crlf)
  (printout t "Choice Book")
  (printout t crlf crlf))

(defrule print-advice ""
  (declare (salience 10))
  (advice ?item)
  =>
  (printout t crlf crlf)
  (printout t "Suggested Advice:")
  (printout t crlf crlf)
  (format t " %s%n%n%n" ?item))
