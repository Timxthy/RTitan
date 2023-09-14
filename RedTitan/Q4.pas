program CountUniqueLetters;
var
  sentence: string;
  letterCounts: array['A'..'Z'] of integer;
  ch: char;
begin
  // Initialize the array to zero
  for ch := 'A' to 'Z' do
    letterCounts[ch] := 0;

  // Input the sentence
  write('Enter a sentence: ');
  readln(sentence);

  // Count unique letters
  for ch in sentence do
  begin
    if UpCase(ch) in ['A'..'Z'] then
      letterCounts[UpCase(ch)] := letterCounts[UpCase(ch)] + 1;
  end;

  // Display the counts
  writeln('Unique letter counts:');
  for ch := 'A' to 'Z' do
  begin
    if letterCounts[ch] > 0 then
      writeln(ch, ': ', letterCounts[ch]);
  end;

  readln;
end.