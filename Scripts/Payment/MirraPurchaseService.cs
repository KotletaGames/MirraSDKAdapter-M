using KotletaGames.ArchitectureCoreModule;
using romanlee17.MirraGames;
using romanlee17.MirraGames.Interfaces;
using System;

public class MirraPurchaseService : PurchaseServiceBase
{
    public override bool IsProductsReady => MirraSDK.Payments.IsProductsReady;

    public override void Purchase(int id, Action onSuccess, Action onError = null)
    {
        Action onSuccessArgs = onSuccess + (() => base.Purchase(id, onSuccess, onError));

        string productTag = id.ToString();
        MirraSDK.Payments.Purchase(
            productTag: productTag,
            onSuccess: onSuccessArgs, 
            onError: onError);
    }

    public override void Consume(int id, Action onProductConsume)
    {
        Action onProductConsumeArgs = onProductConsume + (() => base.Consume(id, onProductConsume));

        MirraSDK.Payments.Fetch(onFetchSuccess: (IFetchData fetchData) =>
        {
            string productTag = id.ToString();
            fetchData.ConsumeProduct(
                productTag: productTag,
                onProductConsume: onProductConsumeArgs);
        });
    }

    public override bool IsPurchased(int id)
    {
        string productTag = id.ToString();
        return MirraSDK.Payments.IsAlreadyPurchased(productTag);
    }

    public override bool TryRecievePurchaseInfo<T>(out T purchaseInfo, int id)
            where T : class
    {
        purchaseInfo = default;
        if (IsProductsReady == false)
            return false;

        string tag = id.ToString();
        IProductData productData = MirraSDK.Payments.GetProductData(tag);
        purchaseInfo = new PurchaseInfo(id, productData.GetFullPriceSingle()) as T;

        return true;
    }
}