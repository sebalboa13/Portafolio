# Generated by Django 3.1.3 on 2021-10-27 01:41

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0007_auto_20211026_2239'),
    ]

    operations = [
        migrations.AddField(
            model_name='facturaxxi',
            name='tipo_pago',
            field=models.IntegerField(null=True),
        ),
        migrations.AddField(
            model_name='productosxxi',
            name='tipo_producto_xxi_id_tipo_producto',
            field=models.ForeignKey(db_column='tipo_producto_xxi_id_tipo_producto', null=True, on_delete=django.db.models.deletion.DO_NOTHING, to='main.tipoproductoxxi'),
        ),
    ]
