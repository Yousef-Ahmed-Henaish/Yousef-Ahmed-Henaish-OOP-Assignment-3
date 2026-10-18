namespace RefactoringLab.Part02.Reports.Exporters;

public class TextReportExporter : Exporter
{
    public override string Format(List<string[]> rows) =>
        string.Join(Environment.NewLine, rows.Select(r => string.Join(" | ", r)));
}
