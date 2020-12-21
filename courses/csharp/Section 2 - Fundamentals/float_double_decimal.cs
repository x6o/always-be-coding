static void Main(string[] args)
{
    float f_no = 0.0f;
    double d_no = 0.0d;
    decimal m_no = 0.0m;

    f_no = 1 / 3f;
    d_no = 1 / 3d;
    m_no = 1 / 3m;

    // Placeholder
    Console.WriteLine("Float nr: {0}", f_no);
    Console.WriteLine("Double nr: {0}", d_no);
    Console.WriteLine("Decimal nr: {0}", m_no);

    // Result
    // Float nr: 0,33333334
    // Double nr: 0,3333333333333333
    // Decimal nr: 0,3333333333333333333333333333

    // To note
    // float: 
    //      size: 4 bytes
    //      precision: 7 digits
    // double:
    //      size: 8 bytes
    //      precision: 15-16 digits
    // decimal:
    //      size: 16 bytes
    //      precision: 28-29 decimal places
}