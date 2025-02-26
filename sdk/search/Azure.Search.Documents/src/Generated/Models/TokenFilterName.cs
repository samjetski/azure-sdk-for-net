// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines the names of all token filters supported by the search engine. </summary>
    public readonly partial struct TokenFilterName : IEquatable<TokenFilterName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TokenFilterName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TokenFilterName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ArabicNormalizationValue = "arabic_normalization";
        private const string ApostropheValue = "apostrophe";
        private const string AsciiFoldingValue = "asciifolding";
        private const string CjkBigramValue = "cjk_bigram";
        private const string CjkWidthValue = "cjk_width";
        private const string ClassicValue = "classic";
        private const string CommonGramValue = "common_grams";
        private const string EdgeNGramValue = "edgeNGram_v2";
        private const string ElisionValue = "elision";
        private const string GermanNormalizationValue = "german_normalization";
        private const string HindiNormalizationValue = "hindi_normalization";
        private const string IndicNormalizationValue = "indic_normalization";
        private const string KeywordRepeatValue = "keyword_repeat";
        private const string KStemValue = "kstem";
        private const string LengthValue = "length";
        private const string LimitValue = "limit";
        private const string LowercaseValue = "lowercase";
        private const string NGramValue = "nGram_v2";
        private const string PersianNormalizationValue = "persian_normalization";
        private const string PhoneticValue = "phonetic";
        private const string PorterStemValue = "porter_stem";
        private const string ReverseValue = "reverse";
        private const string ScandinavianNormalizationValue = "scandinavian_normalization";
        private const string ScandinavianFoldingNormalizationValue = "scandinavian_folding";
        private const string ShingleValue = "shingle";
        private const string SnowballValue = "snowball";
        private const string SoraniNormalizationValue = "sorani_normalization";
        private const string StemmerValue = "stemmer";
        private const string StopwordsValue = "stopwords";
        private const string TrimValue = "trim";
        private const string TruncateValue = "truncate";
        private const string UniqueValue = "unique";
        private const string UppercaseValue = "uppercase";
        private const string WordDelimiterValue = "word_delimiter";

        /// <summary> A token filter that applies the Arabic normalizer to normalize the orthography. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/ar/ArabicNormalizationFilter.html. </summary>
        public static TokenFilterName ArabicNormalization { get; } = new TokenFilterName(ArabicNormalizationValue);
        /// <summary> Strips all characters after an apostrophe (including the apostrophe itself). See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/tr/ApostropheFilter.html. </summary>
        public static TokenFilterName Apostrophe { get; } = new TokenFilterName(ApostropheValue);
        /// <summary> Converts alphabetic, numeric, and symbolic Unicode characters which are not in the first 127 ASCII characters (the "Basic Latin" Unicode block) into their ASCII equivalents, if such equivalents exist. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/ASCIIFoldingFilter.html. </summary>
        public static TokenFilterName AsciiFolding { get; } = new TokenFilterName(AsciiFoldingValue);
        /// <summary> Forms bigrams of CJK terms that are generated from the standard tokenizer. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/cjk/CJKBigramFilter.html. </summary>
        public static TokenFilterName CjkBigram { get; } = new TokenFilterName(CjkBigramValue);
        /// <summary> Normalizes CJK width differences. Folds fullwidth ASCII variants into the equivalent basic Latin, and half-width Katakana variants into the equivalent Kana. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/cjk/CJKWidthFilter.html. </summary>
        public static TokenFilterName CjkWidth { get; } = new TokenFilterName(CjkWidthValue);
        /// <summary> Removes English possessives, and dots from acronyms. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/standard/ClassicFilter.html. </summary>
        public static TokenFilterName Classic { get; } = new TokenFilterName(ClassicValue);
        /// <summary> Construct bigrams for frequently occurring terms while indexing. Single terms are still indexed too, with bigrams overlaid. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/commongrams/CommonGramsFilter.html. </summary>
        public static TokenFilterName CommonGram { get; } = new TokenFilterName(CommonGramValue);
        /// <summary> Generates n-grams of the given size(s) starting from the front or the back of an input token. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/ngram/EdgeNGramTokenFilter.html. </summary>
        public static TokenFilterName EdgeNGram { get; } = new TokenFilterName(EdgeNGramValue);
        /// <summary> Removes elisions. For example, "l'avion" (the plane) will be converted to "avion" (plane). See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/util/ElisionFilter.html. </summary>
        public static TokenFilterName Elision { get; } = new TokenFilterName(ElisionValue);
        /// <summary> Normalizes German characters according to the heuristics of the German2 snowball algorithm. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/de/GermanNormalizationFilter.html. </summary>
        public static TokenFilterName GermanNormalization { get; } = new TokenFilterName(GermanNormalizationValue);
        /// <summary> Normalizes text in Hindi to remove some differences in spelling variations. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/hi/HindiNormalizationFilter.html. </summary>
        public static TokenFilterName HindiNormalization { get; } = new TokenFilterName(HindiNormalizationValue);
        /// <summary> Normalizes the Unicode representation of text in Indian languages. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/in/IndicNormalizationFilter.html. </summary>
        public static TokenFilterName IndicNormalization { get; } = new TokenFilterName(IndicNormalizationValue);
        /// <summary> Emits each incoming token twice, once as keyword and once as non-keyword. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/KeywordRepeatFilter.html. </summary>
        public static TokenFilterName KeywordRepeat { get; } = new TokenFilterName(KeywordRepeatValue);
        /// <summary> A high-performance kstem filter for English. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/en/KStemFilter.html. </summary>
        public static TokenFilterName KStem { get; } = new TokenFilterName(KStemValue);
        /// <summary> Removes words that are too long or too short. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/LengthFilter.html. </summary>
        public static TokenFilterName Length { get; } = new TokenFilterName(LengthValue);
        /// <summary> Limits the number of tokens while indexing. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/LimitTokenCountFilter.html. </summary>
        public static TokenFilterName Limit { get; } = new TokenFilterName(LimitValue);
        /// <summary> Normalizes token text to lower case. See https://lucene.apache.org/core/6_6_1/analyzers-common/org/apache/lucene/analysis/core/LowerCaseFilter.html. </summary>
        public static TokenFilterName Lowercase { get; } = new TokenFilterName(LowercaseValue);
        /// <summary> Generates n-grams of the given size(s). See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/ngram/NGramTokenFilter.html. </summary>
        public static TokenFilterName NGram { get; } = new TokenFilterName(NGramValue);
        /// <summary> Applies normalization for Persian. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/fa/PersianNormalizationFilter.html. </summary>
        public static TokenFilterName PersianNormalization { get; } = new TokenFilterName(PersianNormalizationValue);
        /// <summary> Create tokens for phonetic matches. See https://lucene.apache.org/core/4_10_3/analyzers-phonetic/org/apache/lucene/analysis/phonetic/package-tree.html. </summary>
        public static TokenFilterName Phonetic { get; } = new TokenFilterName(PhoneticValue);
        /// <summary> Uses the Porter stemming algorithm to transform the token stream. See http://tartarus.org/~martin/PorterStemmer. </summary>
        public static TokenFilterName PorterStem { get; } = new TokenFilterName(PorterStemValue);
        /// <summary> Reverses the token string. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/reverse/ReverseStringFilter.html. </summary>
        public static TokenFilterName Reverse { get; } = new TokenFilterName(ReverseValue);
        /// <summary> Normalizes use of the interchangeable Scandinavian characters. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/ScandinavianNormalizationFilter.html. </summary>
        public static TokenFilterName ScandinavianNormalization { get; } = new TokenFilterName(ScandinavianNormalizationValue);
        /// <summary> Folds Scandinavian characters åÅäæÄÆ-&gt;a and öÖøØ-&gt;o. It also discriminates against use of double vowels aa, ae, ao, oe and oo, leaving just the first one. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/ScandinavianFoldingFilter.html. </summary>
        public static TokenFilterName ScandinavianFoldingNormalization { get; } = new TokenFilterName(ScandinavianFoldingNormalizationValue);
        /// <summary> Creates combinations of tokens as a single token. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/shingle/ShingleFilter.html. </summary>
        public static TokenFilterName Shingle { get; } = new TokenFilterName(ShingleValue);
        /// <summary> A filter that stems words using a Snowball-generated stemmer. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/snowball/SnowballFilter.html. </summary>
        public static TokenFilterName Snowball { get; } = new TokenFilterName(SnowballValue);
        /// <summary> Normalizes the Unicode representation of Sorani text. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/ckb/SoraniNormalizationFilter.html. </summary>
        public static TokenFilterName SoraniNormalization { get; } = new TokenFilterName(SoraniNormalizationValue);
        /// <summary> Language specific stemming filter. See https://docs.microsoft.com/rest/api/searchservice/Custom-analyzers-in-Azure-Search#TokenFilters. </summary>
        public static TokenFilterName Stemmer { get; } = new TokenFilterName(StemmerValue);
        /// <summary> Removes stop words from a token stream. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/core/StopFilter.html. </summary>
        public static TokenFilterName Stopwords { get; } = new TokenFilterName(StopwordsValue);
        /// <summary> Trims leading and trailing whitespace from tokens. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/TrimFilter.html. </summary>
        public static TokenFilterName Trim { get; } = new TokenFilterName(TrimValue);
        /// <summary> Truncates the terms to a specific length. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/TruncateTokenFilter.html. </summary>
        public static TokenFilterName Truncate { get; } = new TokenFilterName(TruncateValue);
        /// <summary> Filters out tokens with same text as the previous token. See http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/RemoveDuplicatesTokenFilter.html. </summary>
        public static TokenFilterName Unique { get; } = new TokenFilterName(UniqueValue);
        /// <summary> Normalizes token text to upper case. See https://lucene.apache.org/core/6_6_1/analyzers-common/org/apache/lucene/analysis/core/UpperCaseFilter.html. </summary>
        public static TokenFilterName Uppercase { get; } = new TokenFilterName(UppercaseValue);
        /// <summary> Splits words into subwords and performs optional transformations on subword groups. </summary>
        public static TokenFilterName WordDelimiter { get; } = new TokenFilterName(WordDelimiterValue);
        /// <summary> Determines if two <see cref="TokenFilterName"/> values are the same. </summary>
        public static bool operator ==(TokenFilterName left, TokenFilterName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TokenFilterName"/> values are not the same. </summary>
        public static bool operator !=(TokenFilterName left, TokenFilterName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TokenFilterName"/>. </summary>
        public static implicit operator TokenFilterName(string value) => new TokenFilterName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TokenFilterName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TokenFilterName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
