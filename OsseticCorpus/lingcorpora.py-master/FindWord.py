import lingcorpora

word = input()
corp = lingcorpora.Corpus('ose')
results = corp.search(word, n_results = 1, get_analysis=True)

for result in results:
  for i,target in enumerate(result):
    for tok in target.analysis:
      print(tok['lemma'] + ' ' + tok['tag'])